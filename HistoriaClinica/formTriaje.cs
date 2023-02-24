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
            }
        }

        private void formTriaje_Load(object sender, EventArgs e)
        {
            cbPatologia.DataSource= Patologia.Lista();
            cbPatologia.Text = "Seleccione";

            cbDerivar.DataSource = Usuario.ListaDoctor();
            cbDerivar.Text = "Seleccione";
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            DateTime factual = DateTime.Today;
            Triaje.Add(textDocumento.Text, textTalla.Text, textTemperatura.Text, textPeso.Text,
                 textPresion.Text, cbPatologia.Text, cbDerivar.Text, factual.ToString("d"));
        }
    }
}
