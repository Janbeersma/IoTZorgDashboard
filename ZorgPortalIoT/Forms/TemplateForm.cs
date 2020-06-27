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

        private void HoofdpaginaBttn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HoofdpaginaForm hoofdpaginaForm = new HoofdpaginaForm();
            hoofdpaginaForm.Show();

        }

        private void AccountBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(AccountDropdown);
        }

        private void AccountbeheerBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountbeheerform accountbeheerform = new Accountbeheerform();
            accountbeheerform.Show();

        }

        private void MijnAccountBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MijnAccountForm mijnAccountForm = new MijnAccountForm();
            mijnAccountForm.Show();
        }

        private void MedicatieBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(MedicatieDropdown);
        }

        private void DispBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DispBeheerForm dispBeheerForm = new DispBeheerForm();
            dispBeheerForm.Show();
        }

        private void MedbeheerBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedBeheerForm medBeheerForm = new MedBeheerForm();
            medBeheerForm.Show();
        }

        private void AlarmBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlarmForm alarmForm = new AlarmForm();
            alarmForm.Show();
        }

        private void PatientBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void SettingsBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstellingenForm instellingenForm = new InstellingenForm();
            instellingenForm.Show();
        }
    }
}
