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
            this.PatientInfoPaneel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeeftijdLabel = new System.Windows.Forms.Label();
            this.AchternaamLabel = new System.Windows.Forms.Label();
            this.VoornaamLabel = new System.Windows.Forms.Label();
            this.fotoBox = new System.Windows.Forms.PictureBox();
            this.ContentPanel.SuspendLayout();
            this.PatientInfoPaneel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.fotoBox);
            this.ContentPanel.Controls.Add(this.PatientInfoPaneel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(164, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(436, 366);
            this.ContentPanel.TabIndex = 2;
            // 
            // PatientInfoPaneel
            // 
            this.PatientInfoPaneel.Controls.Add(this.label1);
            this.PatientInfoPaneel.Controls.Add(this.LeeftijdLabel);
            this.PatientInfoPaneel.Controls.Add(this.AchternaamLabel);
            this.PatientInfoPaneel.Controls.Add(this.VoornaamLabel);
            this.PatientInfoPaneel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoPaneel.Location = new System.Drawing.Point(4, 154);
            this.PatientInfoPaneel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientInfoPaneel.Name = "PatientInfoPaneel";
            this.PatientInfoPaneel.Size = new System.Drawing.Size(164, 209);
            this.PatientInfoPaneel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patiënt info";
            // 
            // LeeftijdLabel
            // 
            this.LeeftijdLabel.AutoSize = true;
            this.LeeftijdLabel.Location = new System.Drawing.Point(2, 188);
            this.LeeftijdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LeeftijdLabel.Name = "LeeftijdLabel";
            this.LeeftijdLabel.Size = new System.Drawing.Size(45, 19);
            this.LeeftijdLabel.TabIndex = 2;
            this.LeeftijdLabel.Text = "label3";
            // 
            // AchternaamLabel
            // 
            this.AchternaamLabel.AutoSize = true;
            this.AchternaamLabel.Location = new System.Drawing.Point(2, 128);
            this.AchternaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AchternaamLabel.Name = "AchternaamLabel";
            this.AchternaamLabel.Size = new System.Drawing.Size(45, 19);
            this.AchternaamLabel.TabIndex = 1;
            this.AchternaamLabel.Text = "label2";
            // 
            // VoornaamLabel
            // 
            this.VoornaamLabel.AutoSize = true;
            this.VoornaamLabel.Location = new System.Drawing.Point(2, 72);
            this.VoornaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VoornaamLabel.Name = "VoornaamLabel";
            this.VoornaamLabel.Size = new System.Drawing.Size(45, 19);
            this.VoornaamLabel.TabIndex = 0;
            this.VoornaamLabel.Text = "label1";
            // 
            // fotoBox
            // 
            this.fotoBox.Location = new System.Drawing.Point(5, 3);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Size = new System.Drawing.Size(163, 146);
            this.fotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoBox.TabIndex = 2;
            this.fotoBox.TabStop = false;
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ContentPanel);
            this.Name = "PatientInfoForm";
            this.Text = "PatientInfoForm";
            this.Controls.SetChildIndex(this.ContentPanel, 0);
            this.ContentPanel.ResumeLayout(false);
            this.PatientInfoPaneel.ResumeLayout(false);
            this.PatientInfoPaneel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel PatientInfoPaneel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LeeftijdLabel;
        private System.Windows.Forms.Label AchternaamLabel;
        private System.Windows.Forms.Label VoornaamLabel;
        private System.Windows.Forms.PictureBox fotoBox;
    }
}