﻿using HistoriaClinica.Data;
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
    public partial class formPaciente : Form
    {
        public formPaciente()
        {
            InitializeComponent();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Calendar1.Visible = false;
            }
        }

        private void Calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textFNacimiento.Text = Calendar1.SelectionRange.Start.Date.ToShortDateString();
            DateTime dat = Convert.ToDateTime(textFNacimiento.Text);
            DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;


            textEdad.Text = edad.ToString();
            Calendar1.Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Paciente.Add(textDocumento.Text, textNombre.Text, cbSexo.Text, textFNacimiento.Text,
                 textTelefono.Text, textDomicilio.Text, textCorreo.Text, textLNacimiento.Text);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Paciente.Edit(textDocumento.Text, textNombre.Text, cbSexo.Text, textFNacimiento.Text,
                 textTelefono.Text, textDomicilio.Text, textCorreo.Text, textLNacimiento.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

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
                                    cbSexo.Text = dr["sexo"].ToString();
                                    textFNacimiento.Text = dr["fecha_nacimiento"].ToString();
                                    textDomicilio.Text = dr["domicilio"].ToString();
                                    textTelefono.Text = dr["telefono"].ToString();
                                    textCorreo.Text = dr["correo"].ToString();
                                    textLNacimiento.Text = dr["lugar_nacimiento"].ToString();
                                    DateTime dat = Convert.ToDateTime(textFNacimiento.Text);
                                    DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
                                    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;


                                    textEdad.Text = edad.ToString();


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
    }
}
