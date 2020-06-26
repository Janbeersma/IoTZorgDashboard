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
using System.Data.Entity;

namespace ZorgPortalIoT.Forms
{
    public partial class PatientForm : TemplateForm
    {
        public PatientForm()
        {
            InitializeComponent(); 
            HaalPatientData();
        }

        //Haalt patientdata op en zit deze in een datagridview
        public void HaalPatientData()
        {
            using (b2d4ziekenhuisContext patientData = new b2d4ziekenhuisContext())
            {
                patientData.Patient.Load(); PatientOverviewGrid.DataSource = patientData.Patient.Local.ToBindingList();
            }
        }

        //Maakt cellen klikbaar en gaat naar de patient info pagina
        private void PatientOverviewGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {                                             
            //PatientInfoForm patientInfoForm = new PatientInfoForm();
            //patientInfoForm.ShowDialog();
            //var senderGrid = (DataGridView)sender;

            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            //{
            //    this.Hide();
            //    PatientInfoForm patientInfoForm = new PatientInfoForm();
            //    patientInfoForm.ShowDialog();
            //}
        }
    }
    
}
