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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.toggleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotoBox = new System.Windows.Forms.PictureBox();
            this.PatientInfoPaneel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeeftijdLabel = new System.Windows.Forms.Label();
            this.AchternaamLabel = new System.Windows.Forms.Label();
            this.VoornaamLabel = new System.Windows.Forms.Label();
            this.StappenPaneel = new System.Windows.Forms.Panel();
            this.stepsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ContentPanel.SuspendLayout();
            this.toggleTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).BeginInit();
            this.PatientInfoPaneel.SuspendLayout();
            this.StappenPaneel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.StappenPaneel);
            this.ContentPanel.Controls.Add(this.toggleTableLayoutPanel);
            this.ContentPanel.Controls.Add(this.fotoBox);
            this.ContentPanel.Controls.Add(this.PatientInfoPaneel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(219, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(878, 725);
            this.ContentPanel.TabIndex = 2;
            // 
            // toggleTableLayoutPanel
            // 
            this.toggleTableLayoutPanel.AutoScroll = true;
            this.toggleTableLayoutPanel.AutoSize = true;
            this.toggleTableLayoutPanel.ColumnCount = 2;
            this.toggleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.40926F));
            this.toggleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.59073F));
            this.toggleTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.toggleTableLayoutPanel.Controls.Add(this.label3, 1, 0);
            this.toggleTableLayoutPanel.Location = new System.Drawing.Point(232, 4);
            this.toggleTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleTableLayoutPanel.Name = "toggleTableLayoutPanel";
            this.toggleTableLayoutPanel.RowCount = 1;
            this.toggleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 443F));
            this.toggleTableLayoutPanel.Size = new System.Drawing.Size(345, 443);
            this.toggleTableLayoutPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aan/Uit";
            // 
            // fotoBox
            // 
            this.fotoBox.Location = new System.Drawing.Point(7, 4);
            this.fotoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Size = new System.Drawing.Size(217, 180);
            this.fotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoBox.TabIndex = 2;
            this.fotoBox.TabStop = false;
            // 
            // PatientInfoPaneel
            // 
            this.PatientInfoPaneel.Controls.Add(this.label1);
            this.PatientInfoPaneel.Controls.Add(this.LeeftijdLabel);
            this.PatientInfoPaneel.Controls.Add(this.AchternaamLabel);
            this.PatientInfoPaneel.Controls.Add(this.VoornaamLabel);
            this.PatientInfoPaneel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoPaneel.Location = new System.Drawing.Point(5, 190);
            this.PatientInfoPaneel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientInfoPaneel.Name = "PatientInfoPaneel";
            this.PatientInfoPaneel.Size = new System.Drawing.Size(219, 257);
            this.PatientInfoPaneel.TabIndex = 1;
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
            // LeeftijdLabel
            // 
            this.LeeftijdLabel.AutoSize = true;
            this.LeeftijdLabel.Location = new System.Drawing.Point(3, 128);
            this.LeeftijdLabel.Name = "LeeftijdLabel";
            this.LeeftijdLabel.Size = new System.Drawing.Size(55, 23);
            this.LeeftijdLabel.TabIndex = 2;
            this.LeeftijdLabel.Text = "label3";
            // 
            // AchternaamLabel
            // 
            this.AchternaamLabel.AutoSize = true;
            this.AchternaamLabel.Location = new System.Drawing.Point(3, 90);
            this.AchternaamLabel.Name = "AchternaamLabel";
            this.AchternaamLabel.Size = new System.Drawing.Size(55, 23);
            this.AchternaamLabel.TabIndex = 1;
            this.AchternaamLabel.Text = "label2";
            // 
            // VoornaamLabel
            // 
            this.VoornaamLabel.AutoSize = true;
            this.VoornaamLabel.Location = new System.Drawing.Point(3, 53);
            this.VoornaamLabel.Name = "VoornaamLabel";
            this.VoornaamLabel.Size = new System.Drawing.Size(55, 23);
            this.VoornaamLabel.TabIndex = 0;
            this.VoornaamLabel.Text = "label1";
            // 
            // StappenPaneel
            // 
            this.StappenPaneel.Controls.Add(this.stepsChart);
            this.StappenPaneel.Location = new System.Drawing.Point(6, 452);
            this.StappenPaneel.Name = "StappenPaneel";
            this.StappenPaneel.Size = new System.Drawing.Size(571, 270);
            this.StappenPaneel.TabIndex = 4;
            // 
            // stepsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.stepsChart.ChartAreas.Add(chartArea1);
            this.stepsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.stepsChart.Legends.Add(legend1);
            this.stepsChart.Location = new System.Drawing.Point(0, 0);
            this.stepsChart.Name = "stepsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.stepsChart.Series.Add(series1);
            this.stepsChart.Size = new System.Drawing.Size(571, 270);
            this.stepsChart.TabIndex = 0;
            this.stepsChart.Text = "chart1";
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 725);
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientInfoForm";
            this.Text = "PatientInfoForm";
            this.Controls.SetChildIndex(this.ContentPanel, 0);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.toggleTableLayoutPanel.ResumeLayout(false);
            this.toggleTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).EndInit();
            this.PatientInfoPaneel.ResumeLayout(false);
            this.PatientInfoPaneel.PerformLayout();
            this.StappenPaneel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepsChart)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel toggleTableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel StappenPaneel;
        private System.Windows.Forms.DataVisualization.Charting.Chart stepsChart;
    }
}