﻿namespace HistoriaClinica.Reporte
{
    partial class formReportConsultaPaciente
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rConsultaPacienteFecha = new HistoriaClinica.RConsultaPacienteFecha();
            this.spConsultaPacienteFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ConsultaPacienteFechaTableAdapter = new HistoriaClinica.RConsultaPacienteFechaTableAdapters.sp_ConsultaPacienteFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rConsultaPacienteFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaPacienteFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "consultapacientefecha";
            reportDataSource1.Value = this.spConsultaPacienteFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HistoriaClinica.Reporte.ReportConsultaPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // rConsultaPacienteFecha
            // 
            this.rConsultaPacienteFecha.DataSetName = "RConsultaPacienteFecha";
            this.rConsultaPacienteFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultaPacienteFechaBindingSource
            // 
            this.spConsultaPacienteFechaBindingSource.DataMember = "sp_ConsultaPacienteFecha";
            this.spConsultaPacienteFechaBindingSource.DataSource = this.rConsultaPacienteFecha;
            // 
            // sp_ConsultaPacienteFechaTableAdapter
            // 
            this.sp_ConsultaPacienteFechaTableAdapter.ClearBeforeFill = true;
            // 
            // formReportConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReportConsultaPaciente";
            this.Text = "formReportConsultaPaciente";
            this.Load += new System.EventHandler(this.formReportConsultaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rConsultaPacienteFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaPacienteFechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultaPacienteFechaBindingSource;
        private RConsultaPacienteFecha rConsultaPacienteFecha;
        private RConsultaPacienteFechaTableAdapters.sp_ConsultaPacienteFechaTableAdapter sp_ConsultaPacienteFechaTableAdapter;
    }
}