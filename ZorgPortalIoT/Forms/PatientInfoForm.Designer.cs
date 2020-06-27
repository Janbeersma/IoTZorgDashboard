namespace ZorgPortalIoT.Forms
{
    partial class PatientInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PatientFotoPaneel = new System.Windows.Forms.Panel();
            this.PatientInfoPaneel = new System.Windows.Forms.Panel();
            this.VoornaamLabel = new System.Windows.Forms.Label();
            this.AchternaamLabel = new System.Windows.Forms.Label();
            this.LeeftijdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.PatientInfoPaneel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.PatientInfoPaneel);
            this.ContentPanel.Controls.Add(this.PatientFotoPaneel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(219, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(581, 450);
            this.ContentPanel.TabIndex = 2;
            // 
            // PatientFotoPaneel
            // 
            this.PatientFotoPaneel.Location = new System.Drawing.Point(6, 12);
            this.PatientFotoPaneel.Name = "PatientFotoPaneel";
            this.PatientFotoPaneel.Size = new System.Drawing.Size(219, 146);
            this.PatientFotoPaneel.TabIndex = 0;
            // 
            // PatientInfoPaneel
            // 
            this.PatientInfoPaneel.Controls.Add(this.label1);
            this.PatientInfoPaneel.Controls.Add(this.LeeftijdLabel);
            this.PatientInfoPaneel.Controls.Add(this.AchternaamLabel);
            this.PatientInfoPaneel.Controls.Add(this.VoornaamLabel);
            this.PatientInfoPaneel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoPaneel.Location = new System.Drawing.Point(6, 190);
            this.PatientInfoPaneel.Name = "PatientInfoPaneel";
            this.PatientInfoPaneel.Size = new System.Drawing.Size(219, 257);
            this.PatientInfoPaneel.TabIndex = 1;
            // 
            // VoornaamLabel
            // 
            this.VoornaamLabel.AutoSize = true;
            this.VoornaamLabel.Location = new System.Drawing.Point(3, 89);
            this.VoornaamLabel.Name = "VoornaamLabel";
            this.VoornaamLabel.Size = new System.Drawing.Size(55, 23);
            this.VoornaamLabel.TabIndex = 0;
            this.VoornaamLabel.Text = "label1";
            // 
            // AchternaamLabel
            // 
            this.AchternaamLabel.AutoSize = true;
            this.AchternaamLabel.Location = new System.Drawing.Point(3, 157);
            this.AchternaamLabel.Name = "AchternaamLabel";
            this.AchternaamLabel.Size = new System.Drawing.Size(55, 23);
            this.AchternaamLabel.TabIndex = 1;
            this.AchternaamLabel.Text = "label2";
            // 
            // LeeftijdLabel
            // 
            this.LeeftijdLabel.AutoSize = true;
            this.LeeftijdLabel.Location = new System.Drawing.Point(3, 232);
            this.LeeftijdLabel.Name = "LeeftijdLabel";
            this.LeeftijdLabel.Size = new System.Drawing.Size(55, 23);
            this.LeeftijdLabel.TabIndex = 2;
            this.LeeftijdLabel.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patiënt info";
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Name = "PatientInfoForm";
            this.Text = "PatientInfoForm";
            this.Controls.SetChildIndex(this.ContentPanel, 0);
            this.ContentPanel.ResumeLayout(false);
            this.PatientInfoPaneel.ResumeLayout(false);
            this.PatientInfoPaneel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel PatientInfoPaneel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LeeftijdLabel;
        private System.Windows.Forms.Label AchternaamLabel;
        private System.Windows.Forms.Label VoornaamLabel;
        private System.Windows.Forms.Panel PatientFotoPaneel;
    }
}