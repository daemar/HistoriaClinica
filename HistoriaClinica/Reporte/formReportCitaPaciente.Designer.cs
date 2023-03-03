namespace HistoriaClinica.Reporte
{
    partial class formReportCitaPaciente
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
            this.rCitaPaciente = new HistoriaClinica.RCitaPaciente();
            this.spConsultaCitaPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ConsultaCitaPacienteTableAdapter = new HistoriaClinica.RCitaPacienteTableAdapters.sp_ConsultaCitaPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rCitaPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaPacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "citapaciente";
            reportDataSource1.Value = this.spConsultaCitaPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HistoriaClinica.Reporte.ReportCitaPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // rCitaPaciente
            // 
            this.rCitaPaciente.DataSetName = "RCitaPaciente";
            this.rCitaPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultaCitaPacienteBindingSource
            // 
            this.spConsultaCitaPacienteBindingSource.DataMember = "sp_ConsultaCitaPaciente";
            this.spConsultaCitaPacienteBindingSource.DataSource = this.rCitaPaciente;
            // 
            // sp_ConsultaCitaPacienteTableAdapter
            // 
            this.sp_ConsultaCitaPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // formReportCitaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReportCitaPaciente";
            this.Text = "formReportCitaPaciente";
            this.Load += new System.EventHandler(this.formReportCitaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rCitaPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaCitaPacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultaCitaPacienteBindingSource;
        private RCitaPaciente rCitaPaciente;
        private RCitaPacienteTableAdapters.sp_ConsultaCitaPacienteTableAdapter sp_ConsultaCitaPacienteTableAdapter;
    }
}