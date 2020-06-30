using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorgPortalIoT.Forms.Realtime
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255,255,255);
        }

        public enum alertState {
            wait,
            start,
            close
        }

        private alertState state;

        private Point location;

        public void showAlert(string alertMessage)
        {
            //Start invisible
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            //Ensure maximum of 10 alerts at one given moment
            string formName;

            for (int i = 1; i <= 10; i++)
            {
                formName = $"A{i.ToString()}";
                //If a form with this name does not exist yet
                if ((AlertForm)Application.OpenForms[formName] == null)
                {
                    this.Name = formName;
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15, Screen.PrimaryScreen.WorkingArea.Height - this.Height * i);
                    this.location = new Point(this.Location.X - 15, this.Location.Y); 
                    //Open spot and name found so stop searching
                    break;
                }
            }

            this.Show();
            this.alertDetailsLabel.Text = alertMessage;
            this.state = alertState.start;

            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.state = alertState.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.state == alertState.wait)
            {
                this.timer1.Interval = 5000;
                this.state = alertState.close;
            }
            else if (this.state == alertState.start)
            {
                this.timer1.Interval = 1;
                this.Opacity += 0.1;
                if (this.location.X < this.Location.X)
                {
                    this.Left--;
                }
                if (this.Opacity == 1.0)
                {
                    this.Location = this.location;
                    this.state = alertState.wait;
                }
            }
            else if (this.state == alertState.close) 
            {
                this.timer1.Interval = 1;
                this.Opacity -= 0.1;
                this.Left -= 3;

                if (this.Opacity == 0.0)
                {
                    this.Close();
                }
            }
        }
    }
}
