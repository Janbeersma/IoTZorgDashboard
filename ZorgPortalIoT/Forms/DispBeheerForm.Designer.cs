﻿namespace ZorgPortalIoT.Forms
{
    partial class DispBeheerForm
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
            this.dispenserDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dispenserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dispenserDataGridView
            // 
            this.dispenserDataGridView.AllowUserToDeleteRows = false;
            this.dispenserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispenserDataGridView.Location = new System.Drawing.Point(170, 43);
            this.dispenserDataGridView.Name = "dispenserDataGridView";
            this.dispenserDataGridView.Size = new System.Drawing.Size(499, 308);
            this.dispenserDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Smart Dispensers";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(675, 43);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 26);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DispBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 366);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dispenserDataGridView);
            this.Name = "DispBeheerForm";
            this.Text = "DispBeheerForm";
            this.Controls.SetChildIndex(this.dispenserDataGridView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dispenserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dispenserDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}