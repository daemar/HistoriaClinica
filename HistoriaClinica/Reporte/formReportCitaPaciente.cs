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
    public partial class formReportCitaPaciente : Form
    {
        public formReportCitaPaciente()
        {
            InitializeComponent();
        }

        private void formReportCitaPaciente_Load(object sender, EventArgs e)
        {
          
                this.sp_ConsultaCitaPacienteTableAdapter.Fill(rCitaPaciente.sp_ConsultaCitaPaciente, idpaciente: formReportCitaPacienteData.idpac, fechaini: formReportCitaPacienteData.fechaini.ToString(), fechafin: formReportCitaPacienteData.fechafin.ToString());
                this.reportViewer1.RefreshReport();
           
        }
    }
}
