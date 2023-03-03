using HistoriaClinica.Data;
using HistoriaClinica.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinica
{
    public partial class formReportCitaDoctorData : Form
    {
        public static string fechafin, iddoc, fechaini;

        private void btnimprime_Click(object sender, EventArgs e)
        {
            fechaini = Picker.Text;
            iddoc = cbDoctor.SelectedValue.ToString();
            fechafin = Picker2.Text;
            formReportCitaDoctor form = new formReportCitaDoctor();
            form.Show();
        }

        public formReportCitaDoctorData()
        {
            InitializeComponent();
        }

        private void formReportCitaDoctorData_Load(object sender, EventArgs e)
        {
            var dt = Usuario.ListaDoctor();
            cbDoctor.DisplayMember = "doctesp";
            cbDoctor.ValueMember = "id";
            cbDoctor.DataSource = dt;

            cbDoctor.Text = "Selecciona";
        }
    }
}
