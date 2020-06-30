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

namespace ZorgPortalIoT.Forms
{
    public partial class DispBeheerForm : TemplateForm
    {
        private b2d4ziekenhuisContext context = new b2d4ziekenhuisContext();
        private BindingList<Sensor> source;

        public DispBeheerForm()
        {
            InitializeComponent();
            LoadDispensers();
        }

        private void LoadDispensers()
        {
            source = new BindingList<Sensor>(context.Sensor.Where(s => s.SensorType == 5).ToList());
            dispenserDataGridView.DataSource = source;

            //Hide unneeded columns
            dispenserDataGridView.Columns["SensorId"].Visible = false;
            dispenserDataGridView.Columns["SensorType"].Visible = false;
            dispenserDataGridView.Columns["SensorMeting"].Visible = false;
            dispenserDataGridView.Columns["SensorTypeNavigation"].Visible = false;
            dispenserDataGridView.Columns["Patient"].Visible = false;

            dispenserDataGridView.Columns.Remove(dispenserDataGridView.Columns["PatientId"]);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn
            {
                DisplayMember = "Voornaam",
                DataPropertyName = "PatientId",
                ValueMember = "PatientId",
                HeaderText = "Patient",
                Name = "PatientDropdown",
                DataSource = context.Patient.ToList()
            };

            dispenserDataGridView.DefaultValuesNeeded += new DataGridViewRowEventHandler(SetDefault);

            dispenserDataGridView.Columns.AddRange(column);
        }

        override public void RefreshData()
        {
            //Refresh code hier
        }

        private void SetDefault(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["PatientDropdown"].Value = (((DataGridViewComboBoxCell)e.Row.Cells["PatientDropdown"]).Items[0] as Patient).PatientId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Add new sensors
            foreach (Sensor sensor in source)
            {
                if (sensor.SensorId == 0)
                {
                    //Set as medicine dispenser type
                    sensor.SensorType = 5;
                    context.Sensor.Add(sensor);
                }
            }
            context.SaveChanges();
        }
    }
}
