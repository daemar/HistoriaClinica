using HistoriaClinica.Data;
using HistoriaClinica.Model;
using HistoriaClinica.Reporte;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HistoriaClinica
{
    public partial class formCita : Form
    {
        bool valerror=false;
        public static string iddoctor, idpac, fecha = string.Empty;
        public formCita()
        {
            InitializeComponent();
        }





        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void formCita_Load(object sender, EventArgs e)
        {
            DateTime factual = DateTime.Today;
            Picker.Text = "";
            Picker.MinDate = DateTime.Today;

            var dt = Usuario.ListaDoctor();
            cbDoctor.DisplayMember = "doctesp";
            cbDoctor.ValueMember = "id";
            cbDoctor.DataSource = dt;
            
            cbDoctor.Text = "Selecciona";
            
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                CConexion cn = new CConexion();
                DataSet ds = new DataSet();
                using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_BuscaPaciente", Conexion))
                        {
                            Conexion.Open();
                            cmd.Parameters.AddWithValue("@id", textDocumento.Text);


                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();

                            using (var dr = cmd.ExecuteReader())
                            {

                                if (dr.Read())
                                {

                                    textNombre.Text = dr["nombre"].ToString();
                                    textSexo.Text = dr["sexo"].ToString();
                                    textFNacimiento.Text = dr["fecha_nacimiento"].ToString();
                                    DateTime dat = Convert.ToDateTime(textFNacimiento.Text);
                                    DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
                                    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;


                                    textEdad.Text = edad.ToString();

                                    textDocumento.ReadOnly = true;
                                }
                                else
                                {
                                    MessageBox.Show("Paciente no Registrado", "Información");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error!  " + ex.Message);
                    }

                }
                textDocumento.BackColor= SystemColors.Window;

            }
        }

        private void Calendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
           
        }

        private void textatencion_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            if (valerror == false)
            {
                Cita.Add(textDocumento.Text, Picker.Text, cbDoctor.SelectedValue.ToString());
                limpliar();
            }
            else
            {
                MessageBox.Show("Debe colocar una fecha correcta de atención");
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
                        if ((dat.Month == 3) && (dat.Day >= 3) && (dat.Day <= 17))
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

        private void Picker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime dat = Picker.Value.Date;
            HorarioDoctorModel horarioDoctorModel = HorarioDoctor.Search(formLogin.iddoctor);
            if ((horarioDoctorModel.lunes == 0)&& (dat.DayOfWeek == DayOfWeek.Monday))
            {
                
                    errorProvider1.SetError(Picker, "Doctor no atiende los lunes");
                valerror = true;


            }
            else
            {
                if ((horarioDoctorModel.martes == 0)&& (dat.DayOfWeek == DayOfWeek.Tuesday))
                {

                    errorProvider1.SetError(Picker, "Doctor no atiende los martes");
                    valerror = true;


                }
                else
                {
                    if ((horarioDoctorModel.miercoles == 0)&& (dat.DayOfWeek == DayOfWeek.Wednesday))
                    {
                       
                            errorProvider1.SetError(Picker, "Doctor no atiende los miércoles");
                        valerror = true;


                    }
                    else
                    {
                        if ((horarioDoctorModel.jueves == 0)&& (dat.DayOfWeek == DayOfWeek.Thursday))
                        {
                            
                                errorProvider1.SetError(Picker, "Doctor no atiende los jueves");
                            valerror = true;


                        }
                        else
                        {
                            if ((horarioDoctorModel.viernes == 0)&& (dat.DayOfWeek == DayOfWeek.Friday))
                            {
                               
                                    errorProvider1.SetError(Picker, "Doctor no atiende los viernes");

                                valerror = true;

                            }
                            else
                            {
                                if ((horarioDoctorModel.sabado == 0)&& (dat.DayOfWeek == DayOfWeek.Saturday))
                                {
                                   
                                        errorProvider1.SetError(Picker, "Doctor no atiende los sábado");
                                    valerror = true;
                                }
                                else
                                {
                                    if (dat.DayOfWeek == DayOfWeek.Sunday)
                                    {
                                        errorProvider1.SetError(Picker, "Doctor no atiende los domigos");
                                        valerror = true;

                                    }
                                    else
                                    {
                                        errorProvider1.Clear();
                                        valerror = false;
                                    }
                                }


                                
                            }
                            
                        }
                        
                    }
                    

                }

            }

            if (horarioDoctorModel.fechaini != horarioDoctorModel.fechafin)
            {
                DateTime fini = DateTime.Parse(horarioDoctorModel.fechaini);
                DateTime ffin = DateTime.Parse(horarioDoctorModel.fechafin);
                if ((dat.Date >= fini) && (dat.Date <= ffin))
                {
                    valerror = true;
                    errorProvider1.SetError(Picker, "Doctor no atenderá en las fechas" + fini.ToString("d") + " al " + ffin.ToString("d"));
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpliar()
        {
            this.Controls.OfType<System.Windows.Forms.TextBox>().ToList().ForEach(o => o.Text = "");
            textDocumento.ReadOnly = false;
            textFNacimiento.Text = string.Empty;    
            textEdad.Text= string.Empty;    
            textDocumento.Focus();
        }
        private void btncancela_Click(object sender, EventArgs e)
        {
            limpliar();
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            iddoctor = cbDoctor.SelectedValue.ToString();
            idpac=textDocumento.Text;
            fecha=Picker.Text;

            formReportCita form=new formReportCita();
            form.Show();
        }

      
    }
}
