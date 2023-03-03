namespace HistoriaClinica
{
    partial class formPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.textDocumento = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textLNacimiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlimpia = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.textFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento N°";
            // 
            // textDocumento
            // 
            this.textDocumento.Location = new System.Drawing.Point(17, 62);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.Size = new System.Drawing.Size(176, 20);
            this.textDocumento.TabIndex = 1;
            this.textDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDocumento_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(215, 62);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(176, 20);
            this.textNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre (s) y Apellido (s)";
            // 
            // textEdad
            // 
            this.textEdad.BackColor = System.Drawing.SystemColors.Window;
            this.textEdad.Location = new System.Drawing.Point(216, 115);
            this.textEdad.Name = "textEdad";
            this.textEdad.ReadOnly = true;
            this.textEdad.Size = new System.Drawing.Size(176, 20);
            this.textEdad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(20, 166);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(176, 20);
            this.textTelefono.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(414, 114);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(176, 20);
            this.textDomicilio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Domicilio";
            // 
            // btnagregar
            // 
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.Location = new System.Drawing.Point(117, 221);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Paciente";
            // 
            // textLNacimiento
            // 
            this.textLNacimiento.Location = new System.Drawing.Point(414, 166);
            this.textLNacimiento.Name = "textLNacimiento";
            this.textLNacimiento.Size = new System.Drawing.Size(176, 20);
            this.textLNacimiento.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lugar de Nacimiento";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(215, 166);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(176, 20);
            this.textCorreo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Correo";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(208, 221);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 19;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(383, 221);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 20;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(414, 62);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(176, 21);
            this.cbSexo.TabIndex = 22;
            this.cbSexo.Text = "Seleccione";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFNacimiento);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.btnlimpia);
            this.groupBox1.Controls.Add(this.btncerrar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 285);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(464, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 99);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnlimpia
            // 
            this.btnlimpia.Location = new System.Drawing.Point(297, 221);
            this.btnlimpia.Name = "btnlimpia";
            this.btnlimpia.Size = new System.Drawing.Size(75, 23);
            this.btnlimpia.TabIndex = 20;
            this.btnlimpia.Text = "Limpiar";
            this.btnlimpia.UseVisualStyleBackColor = true;
            this.btnlimpia.Click += new System.EventHandler(this.btnlimpia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // textFNacimiento
            // 
            this.textFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textFNacimiento.Location = new System.Drawing.Point(11, 102);
            this.textFNacimiento.Name = "textFNacimiento";
            this.textFNacimiento.Size = new System.Drawing.Size(173, 20);
            this.textFNacimiento.TabIndex = 23;
            this.textFNacimiento.ValueChanged += new System.EventHandler(this.textFNacimiento_ValueChanged);
            // 
            // formPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 307);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.textLNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medic Control - Paciente";
            this.Load += new System.EventHandler(this.formPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textDocumento;
        public System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnlimpia;
        private System.Windows.Forms.DateTimePicker textFNacimiento;
    }
}