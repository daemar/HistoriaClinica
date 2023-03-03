namespace HistoriaClinica.Reporte
{
    partial class formReportCitaDoctor
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
            this.rCitaDoctor = new HistoriaClinica.RCitaDoctor();
            this.spConsultaCitaPDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ConsultaCitaPDoctorTableAdapter = new HistoriaClinica.RCitaDoctorTableAdapters.sp_ConsultaCitaPDoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rCitaDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaPDoctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "citadoctor";
            reportDataSource1.Value = this.spConsultaCitaPDoctorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HistoriaClinica.Reporte.ReportCitaDoctor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // rCitaDoctor
            // 
            this.rCitaDoctor.DataSetName = "RCitaDoctor";
            this.rCitaDoctor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultaCitaPDoctorBindingSource
            // 
            this.spConsultaCitaPDoctorBindingSource.DataMember = "sp_ConsultaCitaPDoctor";
            this.spConsultaCitaPDoctorBindingSource.DataSource = this.rCitaDoctor;
            // 
            // sp_ConsultaCitaPDoctorTableAdapter
            // 
            this.sp_ConsultaCitaPDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // formReportCitaDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReportCitaDoctor";
            this.Text = "formReportCitaDoctor";
            this.Load += new System.EventHandler(this.formReportCitaDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rCitaDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaPDoctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultaCitaPDoctorBindingSource;
        private RCitaDoctor rCitaDoctor;
        private RCitaDoctorTableAdapters.sp_ConsultaCitaPDoctorTableAdapter sp_ConsultaCitaPDoctorTableAdapter;
    }
}