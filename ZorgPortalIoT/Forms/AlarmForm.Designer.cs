namespace ZorgPortalIoT.Forms
{
    partial class AlarmForm
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
            this.recentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmTotalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.recentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTotalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // recentDataGridView
            // 
            this.recentDataGridView.AllowUserToAddRows = false;
            this.recentDataGridView.AllowUserToDeleteRows = false;
            this.recentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentDataGridView.Location = new System.Drawing.Point(170, 40);
            this.recentDataGridView.Name = "recentDataGridView";
            this.recentDataGridView.ReadOnly = true;
            this.recentDataGridView.Size = new System.Drawing.Size(533, 213);
            this.recentDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recente Alarmen";
            // 
            // alarmTotalChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea1.AxisY.Title = "Aantal alarmen";
            chartArea1.Name = "ChartArea1";
            this.alarmTotalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.alarmTotalChart.Legends.Add(legend1);
            this.alarmTotalChart.Location = new System.Drawing.Point(170, 260);
            this.alarmTotalChart.Name = "alarmTotalChart";
            this.alarmTotalChart.Size = new System.Drawing.Size(533, 300);
            this.alarmTotalChart.TabIndex = 4;
            this.alarmTotalChart.Text = "chart1";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 571);
            this.Controls.Add(this.alarmTotalChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recentDataGridView);
            this.Name = "AlarmForm";
            this.Text = "AlarmForm";
            this.Controls.SetChildIndex(this.recentDataGridView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.alarmTotalChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.recentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTotalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart alarmTotalChart;
    }
}