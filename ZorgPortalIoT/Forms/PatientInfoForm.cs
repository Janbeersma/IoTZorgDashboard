using System;
using System.Collections.Generic;
using System.ComponentModel;
using ZorgPortalIoT.Model;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ZorgPortalIoT.Forms
{
    public partial class PatientInfoForm : TemplateForm
    {
        private int PatientId { get; set; }

        public PatientInfoForm(int patientId)
        {
            InitializeComponent();
            PatientId = patientId;
            GetPatientInfo();
            GenerateGraph();
            GetReadings();
        }

        //Method om data uit patient te halen verdere logica volgt nog
        public void GetPatientInfo()
        {
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                //Haal patient op en vul de labels in
                Patient patient = context.Patient.Find(PatientId);
                VoornaamLabel.Text = $"Voornaam: {patient.Voornaam}";
                AchternaamLabel.Text = $"Achternaam: {patient.Achternaam}";
                LeeftijdLabel.Text = $"Leeftijd: {patient.Leeftijd.ToString()}";
                fotoBox.ImageLocation = patient.FotoUrl;

                

                //Maak knop voor elke sensor die de patient heeft
                foreach (Sensor sensor in context.Sensor.Where(s => s.PatientId == PatientId).ToList())
                {
                    AddToggleButton(sensor.SensorId, (bool)sensor.Aan, string.IsNullOrEmpty(sensor.Naam) ? context.SensorType.First(type => type.TypeId == sensor.SensorType).Naam : sensor.Naam);
                }
                //Voeg één lege rij toe, zodat de knoppen niet verspringen
                this.toggleTableLayoutPanel.RowCount++;
            }
        }

        //Haalt de meest recente sensorwaardes op
        private void GetReadings()
        {
            string hartslag = null;
            string temperatuur = null;

            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Patient patient = context.Patient.Find(PatientId);
                //Haal meest recente hartslag en temperatuur op
                int? hartslagMeterId = context.Sensor.FirstOrDefault(sensor => sensor.PatientId == PatientId && sensor.SensorType == 2)?.SensorId;
                int? temperatuurmeterId = context.Sensor.FirstOrDefault(sensor => sensor.PatientId == PatientId && sensor.SensorType == 3)?.SensorId;
                
                if (hartslagMeterId != null)
                {
                    hartslag = context.SensorMeting.OrderByDescending(v => v.MetingId).FirstOrDefault(meting => meting.SensorId == hartslagMeterId)?.MetingWaarde.ToString("0.0");
                }
                if (temperatuurmeterId != null)
                {
                    temperatuur = context.SensorMeting.OrderByDescending(v => v.MetingId).FirstOrDefault(meting => meting.SensorId == temperatuurmeterId)?.MetingWaarde.ToString("0.0");
                }
            }

            if (InvokeRequired)
            {
                this.Invoke((Action<string, string>)SetReadings, hartslag, temperatuur);
            }
            else
            {
                SetReadings(hartslag, temperatuur);
            }
                
        }

        //Zet de waardes voor hartslagmeter en temperatuutmeter
        private void SetReadings(string hartslag, string temperatuur)
        {
            hartslagLabel.Text = $"{hartslag} BPM";
            temperatuurLabel.Text = $"{temperatuur} °C";
        }

        //Voegt een aan/uit knop toe aan de tabel
        private void AddToggleButton(int id, bool aan, string naam)
        {
            //De toggle knop
            Button toggleButton = new Button()
            {
                Text = aan ? "Zet uit" : "Zet aan",
                Name = id.ToString(),
                Anchor = AnchorStyles.None
            };
            //Koppel button aan de SensorToggle_Click functie
            toggleButton.Click += new EventHandler(SensorToggle_Click);
            //Label dat de naam displayed
            Label naamLabel = new Label()
            {
                Text = naam,
                Anchor = AnchorStyles.None
            };

            int targetrow = this.toggleTableLayoutPanel.RowCount;
            //Voeg controls toe, en voeg rij toe
            this.toggleTableLayoutPanel.Controls.Add(naamLabel, 0, targetrow);
            this.toggleTableLayoutPanel.Controls.Add(toggleButton, 1, targetrow);
            this.toggleTableLayoutPanel.RowCount++;
        }

        private void SensorToggle_Click(object sender, EventArgs e)
        {
            Button toggleButton = (Button)sender;
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Sensor sensor = context.Sensor.Find(Convert.ToInt32(toggleButton.Name));
                if (sensor != null)
                {
                    if ((bool)sensor.Aan)
                    {
                        sensor.Aan = false;
                        toggleButton.Text = "Zet aan";
                    }
                    else
                    {
                        sensor.Aan = true;
                        toggleButton.Text = "Zet uit";
                    }
                    context.SaveChanges();
                }
            }
        }

        private void GenerateGraph()
        {
            Console.WriteLine("Wack");
            //Verwijder oude punten
            if (InvokeRequired)
            {
                this.Invoke((Action)delegate
                {
                    stappentellerChart.Series[0].Points.Clear();
                });
            }
            else
            {
                stappentellerChart.Series[0].Points.Clear();
            }

            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Sensor stappenteller = context.Sensor.FirstOrDefault(sensor => sensor.PatientId == PatientId && sensor.SensorType == 1);
                if (stappenteller == null) { return; }
                //Bereken het aantal gelopen meter per dag van de afgelopen 7 dagen
                var dagen = from meting in context.SensorMeting
                            where meting.MetingTimestamp > DateTime.Now.AddDays(-7) && meting.SensorId == stappenteller.SensorId
                            let dateTime = ((DateTime)meting.MetingTimestamp).Date
                            group meting by dateTime into groep
                            select new
                            {
                                dag = groep.Key,
                                gemiddelde = groep.Sum(m => m.MetingWaarde)
                            };

                foreach (var dag in dagen)
                {
                    if (InvokeRequired)
                    {
                        this.Invoke((Action) delegate 
                        {
                            stappentellerChart.Series[0].Points.AddXY(dag.dag.ToShortDateString(), dag.gemiddelde);
                        });
                    }
                    else
                    {
                        stappentellerChart.Series[0].Points.AddXY(dag.dag.ToShortDateString(), dag.gemiddelde);
                    }
                    
                }
            }
        }

        override public void RefreshData()
        {
            //Refresh code hier
            if (this.IsHandleCreated)
            {
                GenerateGraph();
                GetReadings();
            }
        }
    }
}
