namespace ZorgPortalIoT.Forms
{
    partial class HoofdpaginaForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sensorTypeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorTypeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.sensorTypeChart);
            this.contentPanel.Location = new System.Drawing.Point(169, 12);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(758, 426);
            this.contentPanel.TabIndex = 2;
            // 
            // sensorTypeChart
            // 
            chartArea1.AxisX.Title = "Sensortype";
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Aantal actief";
            chartArea1.Name = "ChartArea1";
            this.sensorTypeChart.ChartAreas.Add(chartArea1);
            this.sensorTypeChart.Location = new System.Drawing.Point(3, 3);
            this.sensorTypeChart.Name = "sensorTypeChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "sensorCountSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.sensorTypeChart.Series.Add(series1);
            this.sensorTypeChart.Size = new System.Drawing.Size(752, 420);
            this.sensorTypeChart.TabIndex = 0;
            this.sensorTypeChart.Text = "chart1";
            // 
            // HoofdpaginaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.contentPanel);
            this.Name = "HoofdpaginaForm";
            this.Text = "HoofdpaginaForm";
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sensorTypeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart sensorTypeChart;
    }
}