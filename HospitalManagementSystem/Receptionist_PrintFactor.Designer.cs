﻿
namespace HospitalManagementSystem
{
    partial class Receptionist_PrintFactor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new HospitalManagementSystem.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BillFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillFactorBindingSource
            // 
            this.BillFactorBindingSource.DataMember = "BillFactor";
            this.BillFactorBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BillFactorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalManagementSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Receptionist_PrintFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "Receptionist_PrintFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پرینت قبض";
            this.Load += new System.EventHandler(this.Reseptionist_PrintFactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillFactorBindingSource;
        private DataSet1 DataSet1;
    }
}