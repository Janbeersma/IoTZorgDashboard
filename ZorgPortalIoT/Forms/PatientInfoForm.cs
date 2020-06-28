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

        //Method om data uit patient te halen verdere logica volgt nog
        public void GetPatientInfo()
        {
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Patient patient = context.Patient.Find(PatientId);
                VoornaamLabel.Text = patient.Voornaam;
                AchternaamLabel.Text = patient.Achternaam;
                LeeftijdLabel.Text = patient.Leeftijd.ToString();

                fotoBox.ImageLocation = patient.FotoUrl;
            }
        }

        override public void RefreshData()
        {
            //Refresh code hier
        }
    }
}
