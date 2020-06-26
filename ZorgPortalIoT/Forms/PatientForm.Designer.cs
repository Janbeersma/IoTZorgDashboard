namespace ZorgPortalIoT.Forms
{
    partial class PatientForm
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
            this.PatientOverzichtPaneel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientOverviewGrid = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientOverzichtPaneel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientOverviewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientOverzichtPaneel
            // 
            this.PatientOverzichtPaneel.Controls.Add(this.label1);
            this.PatientOverzichtPaneel.Controls.Add(this.PatientOverviewGrid);
            this.PatientOverzichtPaneel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientOverzichtPaneel.Location = new System.Drawing.Point(219, 0);
            this.PatientOverzichtPaneel.Name = "PatientOverzichtPaneel";
            this.PatientOverzichtPaneel.Size = new System.Drawing.Size(886, 527);
            this.PatientOverzichtPaneel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // PatientOverviewGrid
            // 
            this.PatientOverviewGrid.AllowUserToAddRows = false;
            this.PatientOverviewGrid.AllowUserToDeleteRows = false;
            this.PatientOverviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientOverviewGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PatientOverviewGrid.Location = new System.Drawing.Point(0, 320);
            this.PatientOverviewGrid.Name = "PatientOverviewGrid";
            this.PatientOverviewGrid.ReadOnly = true;
            this.PatientOverviewGrid.RowHeadersWidth = 51;
            this.PatientOverviewGrid.RowTemplate.Height = 24;
            this.PatientOverviewGrid.Size = new System.Drawing.Size(886, 207);
            this.PatientOverviewGrid.TabIndex = 0;
            this.PatientOverviewGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientOverviewGrid_CellDoubleClick_1);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ZorgPortalIoT.Model.Patient);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 527);
            this.Controls.Add(this.PatientOverzichtPaneel);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Controls.SetChildIndex(this.PatientOverzichtPaneel, 0);
            this.PatientOverzichtPaneel.ResumeLayout(false);
            this.PatientOverzichtPaneel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientOverviewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PatientOverzichtPaneel;
        private System.Windows.Forms.DataGridView PatientOverviewGrid;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Label label1;
    }
}