namespace HistoriaClinica
{
    partial class formHorarioDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHorarioDoctor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnguarda = new System.Windows.Forms.Button();
            this.checkdias = new System.Windows.Forms.CheckedListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lfechafin = new System.Windows.Forms.Label();
            this.lfechaini = new System.Windows.Forms.Label();
            this.Fechafinal = new System.Windows.Forms.DateTimePicker();
            this.Fechaini = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btncerrar);
            this.groupBox1.Controls.Add(this.btnguarda);
            this.groupBox1.Controls.Add(this.checkdias);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lfechafin);
            this.groupBox1.Controls.Add(this.lfechaini);
            this.groupBox1.Controls.Add(this.Fechafinal);
            this.groupBox1.Controls.Add(this.Fechaini);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Días no atención";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(261, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 67);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(180, 180);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 14;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnguarda
            // 
            this.btnguarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguarda.Location = new System.Drawing.Point(82, 180);
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.Size = new System.Drawing.Size(75, 23);
            this.btnguarda.TabIndex = 14;
            this.btnguarda.Text = "Guardar";
            this.btnguarda.UseVisualStyleBackColor = true;
            this.btnguarda.Click += new System.EventHandler(this.btnguarda_Click);
            // 
            // checkdias
            // 
            this.checkdias.Enabled = false;
            this.checkdias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdias.FormattingEnabled = true;
            this.checkdias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.checkdias.Location = new System.Drawing.Point(31, 56);
            this.checkdias.Name = "checkdias";
            this.checkdias.Size = new System.Drawing.Size(94, 94);
            this.checkdias.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(198, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Entre fechas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Enter += new System.EventHandler(this.radioButton2_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por días de la semana";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Enter += new System.EventHandler(this.radioButton1_Enter);
            // 
            // lfechafin
            // 
            this.lfechafin.AutoSize = true;
            this.lfechafin.Enabled = false;
            this.lfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfechafin.Location = new System.Drawing.Point(214, 114);
            this.lfechafin.Name = "lfechafin";
            this.lfechafin.Size = new System.Drawing.Size(51, 13);
            this.lfechafin.TabIndex = 9;
            this.lfechafin.Text = "Fecha fin";
            // 
            // lfechaini
            // 
            this.lfechaini.AutoSize = true;
            this.lfechaini.Enabled = false;
            this.lfechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfechaini.Location = new System.Drawing.Point(214, 61);
            this.lfechaini.Name = "lfechaini";
            this.lfechaini.Size = new System.Drawing.Size(64, 13);
            this.lfechaini.TabIndex = 10;
            this.lfechaini.Text = "Fecha inicio";
            // 
            // Fechafinal
            // 
            this.Fechafinal.Enabled = false;
            this.Fechafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechafinal.Location = new System.Drawing.Point(217, 130);
            this.Fechafinal.Name = "Fechafinal";
            this.Fechafinal.Size = new System.Drawing.Size(109, 20);
            this.Fechafinal.TabIndex = 7;
            // 
            // Fechaini
            // 
            this.Fechaini.Enabled = false;
            this.Fechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechaini.Location = new System.Drawing.Point(217, 77);
            this.Fechaini.Name = "Fechaini";
            this.Fechaini.Size = new System.Drawing.Size(109, 20);
            this.Fechaini.TabIndex = 8;
            // 
            // formHorarioDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "formHorarioDoctor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Días no atención";
            this.Load += new System.EventHandler(this.formHorarioDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkdias;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lfechafin;
        private System.Windows.Forms.Label lfechaini;
        private System.Windows.Forms.DateTimePicker Fechafinal;
        private System.Windows.Forms.DateTimePicker Fechaini;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}