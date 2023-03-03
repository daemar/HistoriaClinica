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
    
    public partial class formRptConsultaPacienteData : Form
    {
        public static string idpac, iddoc, fecha;
        public formRptConsultaPacienteData()
        {
            InitializeComponent();
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            textNombre.Text=Paciente.SearchModel(textDocumento.Text).nombre;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void formRptConsultaPacienteData_Load(object sender, EventArgs e)
        {
            var dt = Usuario.ListaDoctor();
            cbDoctor.DisplayMember = "doctesp";
            cbDoctor.ValueMember = "id";
            cbDoctor.DataSource = dt;

            cbDoctor.Text = "Selecciona";
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            idpac = textDocumento.Text;
            iddoc = cbDoctor.SelectedValue.ToString();
            fecha = Picker.Text.ToString();
            formReportConsultaPaciente form =new formReportConsultaPaciente();
            form.Show();
        }
    }
}
