using HistoriaClinica.Data;
using HistoriaClinica.Model;
using HistoriaClinica.Reporte;
using HistoriaClinica.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinica
{
    public partial class formConsulta : Form
    {
        public static string idpaciente, idoctor, fecha;
        public formConsulta()
        {
            InitializeComponent();
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            //Datos Personales
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                PacienteModel pacienteModel=Paciente.SearchModel(textDocumento.Text);
                DateTime factual = DateTime.Today;
                string ftoday = factual.ToString("d");
                TriajeModel triajeModel = Triaje.SearchModel(textDocumento.Text, ftoday, formLogin.iddoctor);
                if (Cita.TieneCita(textDocumento.Text, ftoday) == true)
                {
                    if (triajeModel.patologia != null)
                    {

                        //Datos Paciente
                        textNombre.Text = pacienteModel.nombre;
                        textSexo.Text = pacienteModel.sexo;
                        textFNacimiento.Text = pacienteModel.fechanacimiento;
                        DateTime dat = Convert.ToDateTime(textFNacimiento.Text);
                        DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
                        int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                        textEdad.Text = edad.ToString();

                        //Datos Triaje

                        textTalla.Text = triajeModel.talla;
                        textTemperatura.Text = triajeModel.temperatura;
                        textPeso.Text = triajeModel.peso;
                        textPresion.Text = triajeModel.presionarterial;
                        textPatologia.Text = triajeModel.patologia;

                        ListaConsulta.DataSource = ConsultaMedica.Lista(textDocumento.Text);

                        ListaConsulta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        ListaConsulta.Columns[0].HeaderText = "Fecha Atención";
                        ListaConsulta.Columns[1].HeaderText = "Talla";
                        ListaConsulta.Columns[2].HeaderText = "Temperatura";
                        ListaConsulta.Columns[3].HeaderText = "Peso";
                        ListaConsulta.Columns[4].HeaderText = "Presión Arterial";
                        ListaConsulta.Columns[5].HeaderText = "Patológia";
                        ListaConsulta.Columns[6].HeaderText = "Diágnostico";
                        ListaConsulta.Columns[7].HeaderText = "Medicación";
                        ListaConsulta.Columns[8].HeaderText = "Doctor";
                        DataGridViewColumn Column = ListaConsulta.Columns[9];
                        Column.Visible = false;
                        textDocumento.ReadOnly = true;
                    }

                    else
                    {
                        MessageBox.Show("Paciente no tiene cita con usted hoy", "Información");

                    }

                }
                else
                {
                    MessageBox.Show("Paciente no tiene cita para hoy", "Información");
                }

            }

        }
        private void limpliar()
        {
            this.Controls.OfType<System.Windows.Forms.TextBox>().ToList().ForEach(o => o.Text = "");
            textDocumento.ReadOnly = false;
            textPatologia.Text = string.Empty;
            textDiagnostico.Text = string.Empty;
            textMedicacion.Text = string.Empty; 
            textDocumento.Focus();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            limpliar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((textDocumento.Text!=string.Empty)  &&(textNombre.Text != string.Empty) 
                && (textSexo.Text != string.Empty) && (textFNacimiento.Text != string.Empty)
                && (textTalla.Text != string.Empty) && (textTemperatura.Text != string.Empty)
                && (textPeso.Text != string.Empty) && (textPresion.Text != string.Empty)
                && (textPatologia.Text != string.Empty)) {
                DateTime factual = DateTime.Today;
                ConsultaMedica.Add(textDocumento.Text,formLogin.iddoctor,factual.ToString("d"),textDiagnostico.Text,textMedicacion.Text );
                limpliar();
            }
            else {
                MessageBox.Show("Debe llenar todos los datos","Información");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formConsulta_Load(object sender, EventArgs e)
        {
            ListaConsulta.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#bfdbff");
            ListaConsulta.EnableHeadersVisualStyles = false;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ListaConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idpaciente=textDocumento.Text;
            idoctor = ListaConsulta.CurrentRow.Cells[9].Value.ToString();
            fecha = ListaConsulta.CurrentRow.Cells[0].Value.ToString();
            formReportConsultaPaciente form =new formReportConsultaPaciente();
            form.Show();
        }


    }
}
