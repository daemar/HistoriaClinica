using HistoriaClinica.Data;
using HistoriaClinica.Model;
using HistoriaClinica.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HistoriaClinica
{
    public partial class formUsuario : Form
    {
        
        public formUsuario()
        {
            InitializeComponent();
        }
                            

        private void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {   
               
            
        }


        private void textBox4_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== 27) {
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

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if(cbRol.SelectedIndex == 1)
            {
                cbEspecialidad.Enabled= true;
            }
            else
            {
                cbEspecialidad.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRol.SelectedIndex == 1)
            {
                cbEspecialidad.Enabled = true;
            }
            else
            {
                cbEspecialidad.Enabled = false;
            }
        }

        private void formUsuario_Load(object sender, EventArgs e)
        {
            
            listaUsuario.DataSource = Usuario.Lista();
            listaUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listaUsuario.Columns[0].HeaderText = "Id";
            listaUsuario.Columns[1].HeaderText = "Nombre";
            listaUsuario.Columns[2].HeaderText = "Cargo";
            listaUsuario.Columns[3].HeaderText = "Teléfono";
            listaUsuario.Columns[4].HeaderText = "Correo";
            listaUsuario.Columns[5].HeaderText = "Rol";
            listaUsuario.Columns[6].HeaderText = "Especialidad";
            listaUsuario.Columns[7].HeaderText = "Usuario";
            listaUsuario.Columns[8].HeaderText = "Password";
            listaUsuario.Columns[9].HeaderText = "Estatus";
            listaUsuario.Columns[10].HeaderText = "Fecha de Nacimiento";
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {

            Usuario.Add(textDocumento.Text, textNombre.Text, textFNacimiento.Text, 
                textCargo.Text, textTelefono.Text, textCorreo.Text,cbRol.Text, 
                cbEspecialidad.Text, textusuario.Text, Encrypt.Encriptar(textpwd.Text));

            listaUsuario.DataSource = Usuario.Lista();
            

        }

        private void listaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textDocumento.Text = listaUsuario.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text= listaUsuario.CurrentRow.Cells[1].Value.ToString();
                textFNacimiento.Text = listaUsuario.CurrentRow.Cells[10].Value.ToString();
                textCargo.Text = listaUsuario.CurrentRow.Cells[2].Value.ToString();
                textTelefono.Text = listaUsuario.CurrentRow.Cells[3].Value.ToString();
                textCorreo.Text = listaUsuario.CurrentRow.Cells[4].Value.ToString();
                cbRol.Text = listaUsuario.CurrentRow.Cells[5].Value.ToString();
                DateTime dat = Convert.ToDateTime(textFNacimiento.Text);
                DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                textEdad.Text = edad.ToString();
                cbEspecialidad.Text = listaUsuario.CurrentRow.Cells[6].Value.ToString();
                textusuario.Text = listaUsuario.CurrentRow.Cells[7].Value.ToString();
                textpwd.Text = listaUsuario.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Usuario.Edit(textDocumento.Text, textNombre.Text, textFNacimiento.Text,
                textCargo.Text, textTelefono.Text, textCorreo.Text, cbRol.Text,
                cbEspecialidad.Text, textusuario.Text, Encrypt.Encriptar(textpwd.Text));

            listaUsuario.DataSource = Usuario.Lista();
            limpliar();
        }
        private void limpliar()
        {
            this.Controls.OfType<System.Windows.Forms.TextBox>().ToList().ForEach(o => o.Text = "");
            textDocumento.Focus();

            cbRol.Text = "Seleccione";
            cbEspecialidad.Text = "Seleccione";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            limpliar();
        }
    }
}
