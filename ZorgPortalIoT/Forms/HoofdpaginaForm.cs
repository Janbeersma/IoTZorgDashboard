using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZorgPortalIoT.Forms.Realtime;
using ZorgPortalIoT.Model;

namespace ZorgPortalIoT.Forms
{
    public partial class HoofdpaginaForm : TemplateForm
    {
        public HoofdpaginaForm()
        {
            InitializeComponent();
            updateGraphSenType();

            AlertForm popup = new AlertForm();
            popup.showAlert("Test!");

        }

        //Verwijder oude punten
        private void ClearPoints ()
        {
            this.sensorTypeChart.Series[0].Points.Clear();
        }

        //Voeg nieuw punt toe
        private void AddPoint (string x, int y)
        {
            this.sensorTypeChart.Series[0].Points.AddXY(x, y);
        }

        public void updateGraphSenType()
        {
            //Voer functie uit of de UI thread wanneer de functie op een andere thread word uitgevoerd
            if (InvokeRequired)
            {
                this.Invoke((Action)ClearPoints);
            }
            else
            {
                ClearPoints();
            }

            //Laad nieuwe punten
            using (b2d4ziekenhuisContext senTypeGraphContext = new b2d4ziekenhuisContext())
            {
                foreach (SensorType type in senTypeGraphContext.SensorType.ToList())
                {
                    int totaal = senTypeGraphContext.Sensor.Where(sensor => sensor.SensorType == type.TypeId && (bool)sensor.Aan).Count();

                    if (InvokeRequired)
                    {
                        this.Invoke((Action<string, int>)AddPoint, type.Naam, totaal);
                    }
                    else
                    {
                        AddPoint(type.Naam, totaal);
                    }
                }
            }
        }

        override public void RefreshData()
        {
            //Check of de Form al is geladen, zo niet doe niks
            if (this.IsHandleCreated)
            {
                updateGraphSenType();
            }
        }
    }
}
