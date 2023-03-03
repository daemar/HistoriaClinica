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
    public partial class formReportCita : Form
    {
        public formReportCita()
        {
            InitializeComponent();
        }

        private void formReportCita_Load(object sender, EventArgs e)
        {

            this.sp_ConsultaCitaTableAdapter.Fill(reportCita.sp_ConsultaCita, idpaciente: formCita.idpac, fecha: formCita.fecha, doctor: formCita.iddoctor);
            this.reportViewer1.RefreshReport();
        }
    }
}