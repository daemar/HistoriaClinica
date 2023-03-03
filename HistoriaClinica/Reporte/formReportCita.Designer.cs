namespace HistoriaClinica.Reporte
{
    partial class formReportCita
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
            this.reportCita = new HistoriaClinica.ReportCita();
            this.spConsultaCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ConsultaCitaTableAdapter = new HistoriaClinica.ReportCitaTableAdapters.sp_ConsultaCitaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reportecita";
            reportDataSource1.Value = this.spConsultaCitaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HistoriaClinica.Reporte.ReportCita.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportCita
            // 
            this.reportCita.DataSetName = "ReportCita";
            this.reportCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultaCitaBindingSource
            // 
            this.spConsultaCitaBindingSource.DataMember = "sp_ConsultaCita";
            this.spConsultaCitaBindingSource.DataSource = this.reportCita;
            // 
            // sp_ConsultaCitaTableAdapter
            // 
            this.sp_ConsultaCitaTableAdapter.ClearBeforeFill = true;
            // 
            // formReportCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReportCita";
            this.Text = "formReportCita";
            this.Load += new System.EventHandler(this.formReportCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultaCitaBindingSource;
        private ReportCita reportCita;
        private ReportCitaTableAdapters.sp_ConsultaCitaTableAdapter sp_ConsultaCitaTableAdapter;
    }
}