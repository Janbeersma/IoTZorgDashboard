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
        }

        private void ClearPoints()
        {
            this.stepsChart.Series[0].Points.Clear();
        }

        //Voeg nieuw punt toe
        private void AddPoint(string x, int y)
        {
            this.stepsChart.Series[0].Points.AddXY(x, y);
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

        //Laad de data voor de stappenteller van een patiënt
        public void LoadPatientStepData() 
        {
            if (InvokeRequired)
            {
                this.Invoke((Action)ClearPoints);
            }
            else
            {
                ClearPoints();
            }

            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Sensor sensor = context.Sensor.First(s => s.PatientId == PatientId && s.SensorType == 1);
                foreach (SensorMeting meting in context.SensorMeting.Where(meting => meting.SensorId == sensor.SensorId))
                {
                    meting.ToString();



                }

            }
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

        override public void RefreshData()
        {
            //Refresh code hier
        }
    }
}
