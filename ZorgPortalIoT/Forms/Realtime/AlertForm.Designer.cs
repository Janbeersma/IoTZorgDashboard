namespace ZorgPortalIoT.Forms.Realtime
{
    partial class AlertForm
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
            this.components = new System.ComponentModel.Container();
            this.alertTextLabel = new System.Windows.Forms.Label();
            this.alertDetailsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // alertTextLabel
            // 
            this.alertTextLabel.AutoSize = true;
            this.alertTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.alertTextLabel.Location = new System.Drawing.Point(76, 30);
            this.alertTextLabel.Name = "alertTextLabel";
            this.alertTextLabel.Size = new System.Drawing.Size(84, 31);
            this.alertTextLabel.TabIndex = 0;
            this.alertTextLabel.Text = "Alarm";
            // 
            // alertDetailsLabel
            // 
            this.alertDetailsLabel.AutoSize = true;
            this.alertDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertDetailsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alertDetailsLabel.Location = new System.Drawing.Point(82, 65);
            this.alertDetailsLabel.Name = "alertDetailsLabel";
            this.alertDetailsLabel.Size = new System.Drawing.Size(46, 17);
            this.alertDetailsLabel.TabIndex = 1;
            this.alertDetailsLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZorgPortalIoT.Properties.Resources.alert1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::ZorgPortalIoT.Properties.Resources.closebutton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(333, 30);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 60);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(405, 120);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alertDetailsLabel);
            this.Controls.Add(this.alertTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertForm";
            this.Text = "AlertForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alertTextLabel;
        private System.Windows.Forms.Label alertDetailsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
    }
}