using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorgPortalIoT.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZorgPortalIoT.Forms
{
    public partial class AlarmForm : TemplateForm
    {
        public AlarmForm()
        {
            InitializeComponent();
            LoadTable();
            AlarmChartRefresh();
        }

        //Recente alarmen tabel
        private void LoadTable()
        {
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                //Selecteer 10 meest recente alarmen
                List<SensorMeting> alarmen = (from meting in context.SensorMeting
                            where meting.Alarm == true
                            orderby meting.MetingTimestamp descending
                            select meting).Take(10).ToList();

                List<AlarmDisplay> displayAlarmen = new List<AlarmDisplay>();
                foreach (SensorMeting alarm in alarmen)
                {
                    Sensor sensor = context.Sensor.Find(alarm.SensorId);
                    Patient patient = context.Patient.Find(sensor.PatientId);
                    string typeNaam = context.SensorType.Find(sensor.SensorType).Naam;

                    displayAlarmen.Add(new AlarmDisplay 
                    {
                        PatientNaam = $"{patient.Voornaam} {patient.Achternaam}",
                        SensorNaam = string.IsNullOrEmpty(sensor.Naam) ? typeNaam : sensor.Naam,
                        MetingWaarde = alarm.MetingWaarde,
                        MetingTimestamp = alarm.MetingTimestamp
                    });
                }

                if (InvokeRequired)
                {
                    this.Invoke((Action)delegate
                    {
                        recentDataGridView.DataSource = displayAlarmen;
                    });
                }
                else
                {
                    recentDataGridView.DataSource = displayAlarmen;
                }
                
            }
        }

        //Alarm total chart
        private void AlarmChartRefresh()
        {
            alarmTotalChart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(-7).ToOADate();
            alarmTotalChart.ChartAreas[0].AxisX.Maximum = DateTime.Now.ToOADate();

            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                foreach (SensorType type in context.SensorType.ToList())
                {
                    Series serie = new Series(type.Naam);
                    alarmTotalChart.Series.Add(serie);
                    serie.XValueType = ChartValueType.DateTime;

                    List<int> sensorIds = context.Sensor.Where(sensor => sensor.SensorType == type.TypeId).Select(sensor => sensor.SensorId).ToList();

                    var dagen = from meting in context.SensorMeting
                                where meting.MetingTimestamp > DateTime.Now.AddDays(-7) && meting.Alarm == true && sensorIds.Contains(meting.SensorId)
                                let dateTime = ((DateTime)meting.MetingTimestamp).Date
                                group meting by dateTime into groep
                                select new
                                {
                                    dag = groep.Key,
                                    aantal = groep.Count()
                                };
                    
                    foreach (var dag in dagen)
                    {
                        serie.Points.AddXY(dag.dag, dag.aantal);
                    }
                }
            }
        }

        override public void RefreshData()
        {
            //Refresh code hier
            if (this.IsHandleCreated)
            {
                LoadTable();
            }
            
        }

        private class AlarmDisplay
        {
            public string PatientNaam { get; set; }
            public string SensorNaam { get; set; }
            public double MetingWaarde { get; set; }
            public DateTime? MetingTimestamp { get; set; }
        } 
    }
}
