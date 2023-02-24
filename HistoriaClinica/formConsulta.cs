using HistoriaClinica.Data;
using HistoriaClinica.Model;
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
                TriajeModel triajeModel = Triaje.SearchModel(textDocumento.Text, ftoday, formLogin.valorGlobal);
                
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
                    textPresion.Text=triajeModel.presionarterial;
                    textPatologia.Text=triajeModel.patologia;
                    
                    textDocumento.ReadOnly= true;
                }

                else
                {
                    MessageBox.Show("Paciente no tiene cita con usted hoy", "Información");
               
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
                ConsultaMedica.Add(textDocumento.Text,formLogin.valorGlobal,factual.ToString("d"),textDiagnostico.Text,textMedicacion.Text );
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

        private void Picker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dat = Picker.Value.Date;
            if (dat.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Cancel = true;
            }
            if (dat.DayOfWeek == DayOfWeek.Saturday)
            {
                e.Cancel = true;
            }

            if (dat.DayOfWeek == DayOfWeek.Monday)
            {
                e.Cancel = true;
            }
        }

        private void Picker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dat = Picker.Value.Date;
            if (dat.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(Picker, "Doctor no atiende los domigos.");
                            
            }
            else
            {
                if (dat.DayOfWeek == DayOfWeek.Saturday)
                {
                    errorProvider1.SetError(Picker, "Doctor no atiende los sábados.");
                }
                else
                {
                    if (dat.DayOfWeek == DayOfWeek.Monday)
                    {
                        errorProvider1.SetError(Picker, "Doctor no atiende los lunes.");
                    }
                    else
                    {
                        if ((dat.Month==3) && (dat.Day >= 3) && (dat.Day <= 17))
                        {
                            
                                errorProvider1.SetError(Picker, "Doctor ESTE ES");
                            
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                    
                }

               
            }
            
        }

        private void formConsulta_Load(object sender, EventArgs e)
        {
           
        }
    }
}
