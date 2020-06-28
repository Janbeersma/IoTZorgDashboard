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
            StartRefresh();
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
            Program.SwitchForm(new HoofdpaginaForm());
        }

        private void AccountBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(AccountDropdown);
        }

        private void AccountbeheerBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new Accountbeheerform());
        }

        private void MijnAccountBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new MijnAccountForm());
        }

        private void MedicatieBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(MedicatieDropdown);
        }

        private void DispBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new DispBeheerForm());
        }

        private void MedbeheerBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new MedBeheerForm());
        }

        private void AlarmBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new AlarmForm());
        }

        private void PatientBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new PatientForm());
        }

        private void SettingsBttn_Click(object sender, EventArgs e)
        {
            Program.SwitchForm(new InstellingenForm());
        }
    }
}
