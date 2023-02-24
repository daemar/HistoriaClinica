using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinica.Model;

namespace HistoriaClinica.Data
{
    internal class HorarioDoctor
    {

        public static HorarioDoctorModel Search(string id)
        {
           
            CConexion cn = new CConexion();
            HorarioDoctorModel ds = new HorarioDoctorModel();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_consultaHorario", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@iddoctor", id);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        using (var dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                ds.iddoctor = dr["id_doctor"].ToString();
                                ds.lunes = (int)dr["lunes"];
                                ds.martes = (int)dr["martes"];
                                ds.miercoles = (int)dr["miercoles"];
                                ds.jueves = (int)dr["jueves"];
                                ds.viernes = (int)dr["viernes"];
                                ds.sabado = (int)dr["sabado"];
                                ds.fechaini = dr["fecha_ini"].ToString();
                                ds.fechafin = dr["feccha_final"].ToString();
                            }
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!  " + ex.Message);
                }
                {

                }
            }
            return ds;
        }
        public static void Add(string iddoctor, int lunes, int martes,
            int miercoles, int jueves, int viernes, int sabado, string fechaini, string fechafin)
        {

            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarHorario", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@iddoctor", iddoctor);
                        cmd.Parameters.AddWithValue("@lunes", lunes);
                        cmd.Parameters.AddWithValue("@martes", martes);
                        cmd.Parameters.AddWithValue("@miercoles", miercoles);
                        cmd.Parameters.AddWithValue("@jueves", jueves);
                        cmd.Parameters.AddWithValue("@viernes", viernes);
                        cmd.Parameters.AddWithValue("@sabado", sabado);
                        cmd.Parameters.AddWithValue("@fechaini", fechaini);
                        cmd.Parameters.AddWithValue("@fechafin", fechafin);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Horario guardado de manera éxitosa", "Correcto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                {

                }
            }

        }



        public static void Update(string iddoctor, int lunes, int martes,
            int miercoles, int jueves, int viernes, int sabado, string fechaini, string fechafin)
        {

            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("database")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditarHorario", Conexion))
                    {
                        Conexion.Open();
                        cmd.Parameters.AddWithValue("@iddoctor", iddoctor);
                        cmd.Parameters.AddWithValue("@lunes", lunes);
                        cmd.Parameters.AddWithValue("@martes", martes);
                        cmd.Parameters.AddWithValue("@miercoles", miercoles);
                        cmd.Parameters.AddWithValue("@jueves", jueves);
                        cmd.Parameters.AddWithValue("@viernes", viernes);
                        cmd.Parameters.AddWithValue("@sabado", sabado);
                        cmd.Parameters.AddWithValue("@fechaini", fechaini);
                        cmd.Parameters.AddWithValue("@fechafin", fechafin);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Horario modificado de manera éxitosa", "Correcto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                {

                }
            }

        }

        internal static void Add(int lunes, int martes, int miercoles, int jueves, int viernes, int sabado, string fini, string ffin)
        {
            throw new NotImplementedException();
        }
    }
}
