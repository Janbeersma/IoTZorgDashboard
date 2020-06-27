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
        string mijnPatient;
        Label patientLabel;

        public PatientInfoForm(string _mijnPatient)
        {
            InitializeComponent();
            mijnPatient = _mijnPatient;
            //CreatingLabel();
        }

        //Method om data uit patient te halen verdere logica volgt nog
        public void PatientInfoDisplay()
        {
            using (b2d4ziekenhuisContext patientOverzicht = new b2d4ziekenhuisContext())
            {
                List<string> dataOpslag = new List<string>();

                foreach (Patient data in patientOverzicht.Patient.ToList())
                {                  
                    Convert.ToString(data);
                    
                    
                }
                VoornaamLabel.Controls.Add(data);
            }
           
        }

        //private void CreatingLabel()
        //{          
        //    patientLabel = new Label();
        //    patientLabel.Location = new Point(40, 40);
        //    patientLabel.Text = mijnPatient;
        //    ContentPanel.Controls.Add(patientLabel);
        //    patientLabel.Refresh();
            
        //}


    }
}
