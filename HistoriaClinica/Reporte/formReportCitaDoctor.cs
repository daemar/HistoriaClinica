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
    public partial class formReportCitaDoctor : Form
    {
        public formReportCitaDoctor()
        {
            InitializeComponent();
        }

        private void formReportCitaDoctor_Load(object sender, EventArgs e)
        {
            this.sp_ConsultaCitaPDoctorTableAdapter.Fill(rCitaDoctor.sp_ConsultaCitaPDoctor, iddoctor: formReportCitaDoctorData.iddoc, fechaini: formReportCitaDoctorData.fechaini, fechafin: formReportCitaDoctorData.fechafin);
            this.reportViewer1.RefreshReport();
        }
    }
}
