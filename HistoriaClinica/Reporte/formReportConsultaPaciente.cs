using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinica.Reporte
{
    public partial class formReportConsultaPaciente : Form
    {
        public formReportConsultaPaciente()
        {
            InitializeComponent();
        }

        private void formReportConsultaPaciente_Load(object sender, EventArgs e)
        {
            if (formConsulta.idpaciente != string.Empty) {
                this.sp_ConsultaPacienteFechaTableAdapter.Fill(rConsultaPacienteFecha.sp_ConsultaPacienteFecha, idpaciente: formConsulta.idpaciente, iddoctor: formConsulta.idoctor, fecha: formConsulta.fecha);
            }
            if (formRptConsultaPacienteData.idpac!= string.Empty) {
                this.sp_ConsultaPacienteFechaTableAdapter.Fill(rConsultaPacienteFecha.sp_ConsultaPacienteFecha, idpaciente: formRptConsultaPacienteData.idpac, iddoctor: formRptConsultaPacienteData.iddoc, fecha: formRptConsultaPacienteData.fecha);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
