using HistoriaClinica.Data;
using System;
using System.Collections;
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
    public partial class formTriaje : Form
    {
        public formTriaje()
        {
            InitializeComponent();
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                DateTime factual = DateTime.Today;
                string ftoday = factual.ToString("d");
                if (Cita.TieneCita(textDocumento.Text, ftoday))
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
                        
                } else{
                         MessageBox.Show("Paciente no tiene cita para hoy", "Información");
                    }
            }
           
        }

        private void formTriaje_Load(object sender, EventArgs e)
        {
            var dt = Usuario.ListaDoctor();
            cbDerivar.DisplayMember = "doctesp";
            cbDerivar.ValueMember = "id";
            cbDerivar.DataSource = dt;

            cbDerivar.Text = "Selecciona";
            cbPatologia.DataSource= Patologia.Lista();
            cbPatologia.Text = "Seleccione";

          
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            DateTime factual = DateTime.Today;
            if ((textNombre.Text != "") && (textFNacimiento.Text != "") &&
                       (textSexo.Text != "") && (textPeso.Text != "") && (textPresion.Text != "") &&
                       (textTemperatura.Text != "") && (cbPatologia.Text != "Seleccione"))
            {
                Triaje.Add(textDocumento.Text, textTalla.Text, textTemperatura.Text, textPeso.Text,
                 textPresion.Text, cbPatologia.Text, cbDerivar.SelectedValue.ToString(), factual.ToString("d"));
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos solicitados", "Información");
            }

        }

        private void textTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textPresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '-') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiar()
        {
            this.Controls.OfType<System.Windows.Forms.TextBox>().ToList().ForEach(o => o.Text = "");
            textDocumento.ReadOnly = false;
            textFNacimiento.Text = string.Empty;
            textEdad.Text = string.Empty;
            textDocumento.Focus();
        }
        private void btnlimpia_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
