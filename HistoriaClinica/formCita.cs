using HistoriaClinica.Data;
using HistoriaClinica.Model;
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
    public partial class formCita : Form
    {
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
            cbDoctor.DataSource = Usuario.ListaDoctor();
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
            Cita.Add(textDocumento.Text, Picker.Text,cbDoctor.Text);
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

                
            }
            else
            {
                if ((horarioDoctorModel.martes == 0)&& (dat.DayOfWeek == DayOfWeek.Tuesday))
                {
                   
                        errorProvider1.SetError(Picker, "Doctor no atiende los martes");

                    
                }
                else
                {
                    if ((horarioDoctorModel.miercoles == 0)&& (dat.DayOfWeek == DayOfWeek.Wednesday))
                    {
                       
                            errorProvider1.SetError(Picker, "Doctor no atiende los miércoles");

                       
                    }
                    else
                    {
                        if ((horarioDoctorModel.jueves == 0)&& (dat.DayOfWeek == DayOfWeek.Thursday))
                        {
                            
                                errorProvider1.SetError(Picker, "Doctor no atiende los jueves");

                            
                        }
                        else
                        {
                            if ((horarioDoctorModel.viernes == 0)&& (dat.DayOfWeek == DayOfWeek.Friday))
                            {
                               
                                    errorProvider1.SetError(Picker, "Doctor no atiende los viernes");

                                
                            }
                            else
                            {
                                if ((horarioDoctorModel.sabado == 0)&& (dat.DayOfWeek == DayOfWeek.Saturday))
                                {
                                   
                                        errorProvider1.SetError(Picker, "Doctor no atiende los sábado");
                                    
                                }
                                else
                                {
                                    if (dat.DayOfWeek == DayOfWeek.Sunday)
                                    {
                                        errorProvider1.SetError(Picker, "Doctor no atiende los domigos");

                                    }
                                    else
                                    {
                                        errorProvider1.Clear();
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
                    errorProvider1.SetError(Picker, "Doctor no atenderá en las fechas" + fini.ToString("d") + " al " + ffin.ToString("d"));
                }
            }
        }

 
    }
}
