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
            hoofdpaginaForm.ShowDialog();

        }
    }
}
