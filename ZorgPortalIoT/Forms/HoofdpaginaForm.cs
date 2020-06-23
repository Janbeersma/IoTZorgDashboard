﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ZorgPortalIoT.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorgPortalIoT
{
    public partial class HoofdpaginaForm : Form
    {
        public HoofdpaginaForm()
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
        }

        private void MedicatieBttn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(MedicatieDropdown);
        }

        private void DispenserBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void MedbeheerBttn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void AlarmenBttn_Click(object sender, EventArgs e)
        {

        }

        private void PatientBttn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBttn_Click(object sender, EventArgs e)
        {

        }
    }
}