using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ZorgPortalIoT.Forms;
using ZorgPortalIoT.Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZorgPortalIoT
{
    public partial class HoofdpaginaForm : Form
    {
        public HoofdpaginaForm()
        {
            InitializeComponent();
            DesignOpties();
        }


        //Haalt de data op voor de sensortype graph
        public void updateGraphSenType()
        {
            using (b2d4ziekenhuisContext senTypeGraphContext = new b2d4ziekenhuisContext())
            {
                
                foreach (SensorType type in senTypeGraphContext.SensorType.ToList())
                { 
                    int totaal = senTypeGraphContext.Sensor.Where(sensor => sensor.SensorType == type.TypeId && (bool)sensor.Aan).Count();
                    Series series = this.sensorTypeChart.Series.Add(type.Naam);
                    series.Points.Add(totaal);
                }
            }
        }

        

        //Geeft de mogelijkhijd om designfunctionaliteiten aan te brengen
        private void DesignOpties()
        {
            AccountDropdown.Visible = false;
            MedicatieDropdown.Visible = false;
        }

        //Zet de standaardwaarden van de submenu's op onzichtbaar
        private void HideSubmenu()
        {
            if (AccountDropdown.Visible == true)
                AccountDropdown.Visible = false;
            if (MedicatieDropdown.Visible == true)
                MedicatieDropdown.Visible = false;
        }

        //Wordt gekoppld aan het onclick event om de dropdowns te laten zien
        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void HoofdpaginaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoofdpaginaForm Hoofdform = new HoofdpaginaForm();
            Hoofdform.Show();
        }

        private void AccountBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(AccountDropdown);
        }

        private void AccountbeheerBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            Accountbeheerform Accform = new Accountbeheerform();
            Accform.ShowDialog();            

        }

        private void MijnAccountBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            MijnAccountForm mijnAccountForm = new MijnAccountForm();
            mijnAccountForm.ShowDialog();
        }

        private void MedicatieBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(MedicatieDropdown);
            
        }

        private void DispenserBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            DispBeheerForm dispBehForm = new DispBeheerForm();
            dispBehForm.ShowDialog();

        }

        private void MedbeheerBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            this.Hide();
            MedBeheerForm medBehForm = new MedBeheerForm();
            medBehForm.ShowDialog();
        }

        private void AlarmenBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlarmForm alarmForm = new AlarmForm();
            alarmForm.ShowDialog();
        }

        private void PatientBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm patientForm = new PatientForm();
            patientForm.ShowDialog();
        }

        private void SettingsBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstellingenForm instellingenForm = new InstellingenForm();
            instellingenForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateGraphSenType();
        }
    }
}
