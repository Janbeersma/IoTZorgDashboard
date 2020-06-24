using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ZorgPortalIoT.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorgPortalIoT.Forms
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
            DesignOpties();
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


    }
}
