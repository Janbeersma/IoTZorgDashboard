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
using ZorgPortalIoT.Forms;
using Microsoft.EntityFrameworkCore;

namespace ZorgPortalIoT.Forms
{
    public partial class PatientForm : TemplateForm
    {
        public PatientForm()
        {
            InitializeComponent(); 
            HaalPatientData();
            label1.Hide();
        }

        //Haalt patientdata op uit de database en zet deze in de tabel.
        public void HaalPatientData()
        {
            List<Patient> patienten;
            using (b2d4ziekenhuisContext patientData = new b2d4ziekenhuisContext())
            {
                patienten = patientData.Patient.ToList();
            }

            if (InvokeRequired)
            {
                this.Invoke((Action<List<Patient>>)UpdateTabelData, patienten);
            }
            else
            {
                UpdateTabelData(patienten);
            }
        }

        //Zet een nieuwe lijst patienten als de datasource van de tabel
        private void UpdateTabelData(List<Patient> patienten)
        {
            PatientOverviewGrid.DataSource = patienten;
        }

        //Maakt cellen klikbaar en gaat naar de patient info pagina
        private void PatientOverviewGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(PatientOverviewGrid.Rows[e.RowIndex].Cells[0].Value);
            Program.SwitchForm(new PatientInfoForm(id));
        }

        override public void RefreshData()
        {
            if (this.IsHandleCreated)
            {
                HaalPatientData();
            }
        }

    }
    
}
