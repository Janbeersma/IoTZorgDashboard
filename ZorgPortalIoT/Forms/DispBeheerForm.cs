﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorgPortalIoT.Forms
{
    public partial class DispBeheerForm : Form
    {
        public DispBeheerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoofdpaginaForm hoofdpaginaForm = new HoofdpaginaForm();
            hoofdpaginaForm.ShowDialog();
        }

    }
}