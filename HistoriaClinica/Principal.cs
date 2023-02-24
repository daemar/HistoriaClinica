using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HistoriaClinica.formLogin;

namespace HistoriaClinica
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private bool openForm(string form) {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == form).SingleOrDefault<Form>();
            if (existe != null)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (openForm("formPaciente") ==false)
            {
                formPaciente form = new formPaciente();

                form.Show();
            }
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openForm("formPaciente") == false)
            {
                formPaciente form = new formPaciente();

                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openForm("formUsuario") == false)
            {
                formUsuario form = new formUsuario();

                form.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openForm("formUsuario") == false)
            {
                formUsuario form = new formUsuario();

                form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openForm("formTriaje") == false)
            {
                formTriaje form = new formTriaje();

                form.Show();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (openForm("formTriaje") == false)
            {
                formTriaje form = new formTriaje();

                form.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (openForm("formConsulta") == false)
            {
                formConsulta form = new formConsulta();

                form.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openForm("formConsulta") == false)
            {
                formConsulta form = new formConsulta();

                form.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openForm("formCita") == false)
            {
                formCita form = new formCita();

                form.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (openForm("formCita") == false)
            {
                formCita form = new formCita();

                form.Show();
            }
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            formLogin form = new formLogin(this);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formHorarioDoctor form= new formHorarioDoctor();
            form.Show();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHorarioDoctor form = new formHorarioDoctor();
            form.Show();
        }
    }
}
