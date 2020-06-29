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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.temperaturePicture = new System.Windows.Forms.PictureBox();
            this.temperatuurHeaderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heartratePicture = new System.Windows.Forms.PictureBox();
            this.hartslagHeaderLabel = new System.Windows.Forms.Label();
            this.hartslagLabel = new System.Windows.Forms.Label();
            this.stappentellerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toggleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotoBox = new System.Windows.Forms.PictureBox();
            this.PatientInfoPaneel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeeftijdLabel = new System.Windows.Forms.Label();
            this.AchternaamLabel = new System.Windows.Forms.Label();
            this.VoornaamLabel = new System.Windows.Forms.Label();
            this.temperatuurLabel = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heartratePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stappentellerChart)).BeginInit();
            this.toggleTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).BeginInit();
            this.PatientInfoPaneel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Controls.Add(this.stappentellerChart);
            this.ContentPanel.Controls.Add(this.toggleTableLayoutPanel);
            this.ContentPanel.Controls.Add(this.fotoBox);
            this.ContentPanel.Controls.Add(this.PatientInfoPaneel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(164, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(879, 481);
            this.ContentPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.temperatuurLabel);
            this.panel2.Controls.Add(this.temperaturePicture);
            this.panel2.Controls.Add(this.temperatuurHeaderLabel);
            this.panel2.Location = new System.Drawing.Point(430, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 100);
            this.panel2.TabIndex = 8;
            // 
            // temperaturePicture
            // 
            this.temperaturePicture.Image = global::ZorgPortalIoT.Properties.Resources.temperature;
            this.temperaturePicture.Location = new System.Drawing.Point(132, 3);
            this.temperaturePicture.Name = "temperaturePicture";
            this.temperaturePicture.Size = new System.Drawing.Size(94, 94);
            this.temperaturePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.temperaturePicture.TabIndex = 8;
            this.temperaturePicture.TabStop = false;
            // 
            // temperatuurHeaderLabel
            // 
            this.temperatuurHeaderLabel.AutoSize = true;
            this.temperatuurHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatuurHeaderLabel.Location = new System.Drawing.Point(2, 0);
            this.temperatuurHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperatuurHeaderLabel.Name = "temperatuurHeaderLabel";
            this.temperatuurHeaderLabel.Size = new System.Drawing.Size(127, 25);
            this.temperatuurHeaderLabel.TabIndex = 5;
            this.temperatuurHeaderLabel.Text = "Temperatuur";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.heartratePicture);
            this.panel1.Controls.Add(this.hartslagHeaderLabel);
            this.panel1.Controls.Add(this.hartslagLabel);
            this.panel1.Location = new System.Drawing.Point(174, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 7;
            // 
            // heartratePicture
            // 
            this.heartratePicture.Image = global::ZorgPortalIoT.Properties.Resources.heartrate;
            this.heartratePicture.Location = new System.Drawing.Point(153, 3);
            this.heartratePicture.Name = "heartratePicture";
            this.heartratePicture.Size = new System.Drawing.Size(94, 94);
            this.heartratePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heartratePicture.TabIndex = 7;
            this.heartratePicture.TabStop = false;
            // 
            // hartslagHeaderLabel
            // 
            this.hartslagHeaderLabel.AutoSize = true;
            this.hartslagHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hartslagHeaderLabel.Location = new System.Drawing.Point(2, 0);
            this.hartslagHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hartslagHeaderLabel.Name = "hartslagHeaderLabel";
            this.hartslagHeaderLabel.Size = new System.Drawing.Size(88, 25);
            this.hartslagHeaderLabel.TabIndex = 4;
            this.hartslagHeaderLabel.Text = "Hartslag";
            // 
            // hartslagLabel
            // 
            this.hartslagLabel.AutoSize = true;
            this.hartslagLabel.Location = new System.Drawing.Point(3, 41);
            this.hartslagLabel.Name = "hartslagLabel";
            this.hartslagLabel.Size = new System.Drawing.Size(32, 13);
            this.hartslagLabel.TabIndex = 6;
            this.hartslagLabel.Text = "lorem";
            // 
            // stappentellerChart
            // 
            chartArea2.AxisY.Title = "Afstand in meter";
            chartArea2.Name = "ChartArea1";
            this.stappentellerChart.ChartAreas.Add(chartArea2);
            this.stappentellerChart.Location = new System.Drawing.Point(174, 115);
            this.stappentellerChart.Name = "stappentellerChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.stappentellerChart.Series.Add(series2);
            this.stappentellerChart.Size = new System.Drawing.Size(486, 360);
            this.stappentellerChart.TabIndex = 4;
            this.stappentellerChart.Text = "chart1";
            // 
            // toggleTableLayoutPanel
            // 
            this.toggleTableLayoutPanel.AutoScroll = true;
            this.toggleTableLayoutPanel.ColumnCount = 2;
            this.toggleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.40927F));
            this.toggleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.59073F));
            this.toggleTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.toggleTableLayoutPanel.Controls.Add(this.label3, 1, 0);
            this.toggleTableLayoutPanel.Location = new System.Drawing.Point(665, 3);
            this.toggleTableLayoutPanel.Name = "toggleTableLayoutPanel";
            this.toggleTableLayoutPanel.RowCount = 1;
            this.toggleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.toggleTableLayoutPanel.Size = new System.Drawing.Size(202, 472);
            this.toggleTableLayoutPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aan/Uit";
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
            // PatientInfoPaneel
            // 
            this.PatientInfoPaneel.Controls.Add(this.label1);
            this.PatientInfoPaneel.Controls.Add(this.LeeftijdLabel);
            this.PatientInfoPaneel.Controls.Add(this.AchternaamLabel);
            this.PatientInfoPaneel.Controls.Add(this.VoornaamLabel);
            this.PatientInfoPaneel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoPaneel.Location = new System.Drawing.Point(4, 154);
            this.PatientInfoPaneel.Margin = new System.Windows.Forms.Padding(2);
            this.PatientInfoPaneel.Name = "PatientInfoPaneel";
            this.PatientInfoPaneel.Size = new System.Drawing.Size(164, 321);
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
            this.LeeftijdLabel.Location = new System.Drawing.Point(2, 104);
            this.LeeftijdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LeeftijdLabel.Name = "LeeftijdLabel";
            this.LeeftijdLabel.Size = new System.Drawing.Size(45, 19);
            this.LeeftijdLabel.TabIndex = 2;
            this.LeeftijdLabel.Text = "label3";
            // 
            // AchternaamLabel
            // 
            this.AchternaamLabel.AutoSize = true;
            this.AchternaamLabel.Location = new System.Drawing.Point(2, 73);
            this.AchternaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AchternaamLabel.Name = "AchternaamLabel";
            this.AchternaamLabel.Size = new System.Drawing.Size(45, 19);
            this.AchternaamLabel.TabIndex = 1;
            this.AchternaamLabel.Text = "label2";
            // 
            // VoornaamLabel
            // 
            this.VoornaamLabel.AutoSize = true;
            this.VoornaamLabel.Location = new System.Drawing.Point(2, 43);
            this.VoornaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VoornaamLabel.Name = "VoornaamLabel";
            this.VoornaamLabel.Size = new System.Drawing.Size(45, 19);
            this.VoornaamLabel.TabIndex = 0;
            this.VoornaamLabel.Text = "label1";
            // 
            // temperatuurLabel
            // 
            this.temperatuurLabel.AutoSize = true;
            this.temperatuurLabel.Location = new System.Drawing.Point(4, 41);
            this.temperatuurLabel.Name = "temperatuurLabel";
            this.temperatuurLabel.Size = new System.Drawing.Size(32, 13);
            this.temperatuurLabel.TabIndex = 9;
            this.temperatuurLabel.Text = "lorem";
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 481);
            this.Controls.Add(this.ContentPanel);
            this.Name = "PatientInfoForm";
            this.Text = "PatientInfoForm";
            this.Controls.SetChildIndex(this.ContentPanel, 0);
            this.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heartratePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stappentellerChart)).EndInit();
            this.toggleTableLayoutPanel.ResumeLayout(false);
            this.toggleTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).EndInit();
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
        private System.Windows.Forms.PictureBox fotoBox;
        private System.Windows.Forms.TableLayoutPanel toggleTableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart stappentellerChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox temperaturePicture;
        private System.Windows.Forms.Label temperatuurHeaderLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox heartratePicture;
        private System.Windows.Forms.Label hartslagHeaderLabel;
        private System.Windows.Forms.Label hartslagLabel;
        private System.Windows.Forms.Label temperatuurLabel;
    }
}