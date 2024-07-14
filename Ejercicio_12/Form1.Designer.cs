namespace Ejercicio_12
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbEjemplares = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLibro = new System.Windows.Forms.RadioButton();
            this.rbLibroMaterialDigital = new System.Windows.Forms.RadioButton();
            this.rbRevista = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsbCliente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chBoxPrimeraVez = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lsbEjemplaresCliente = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCompletarPrestano = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lsbEjemplares);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejemplares";
            // 
            // lsbEjemplares
            // 
            this.lsbEjemplares.FormattingEnabled = true;
            this.lsbEjemplares.HorizontalScrollbar = true;
            this.lsbEjemplares.ItemHeight = 20;
            this.lsbEjemplares.Location = new System.Drawing.Point(18, 26);
            this.lsbEjemplares.Name = "lsbEjemplares";
            this.lsbEjemplares.Size = new System.Drawing.Size(580, 224);
            this.lsbEjemplares.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRevista);
            this.groupBox2.Controls.Add(this.rbLibroMaterialDigital);
            this.groupBox2.Controls.Add(this.rbLibro);
            this.groupBox2.Location = new System.Drawing.Point(420, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejemplar";
            // 
            // rbLibro
            // 
            this.rbLibro.AutoSize = true;
            this.rbLibro.Checked = true;
            this.rbLibro.Location = new System.Drawing.Point(24, 26);
            this.rbLibro.Name = "rbLibro";
            this.rbLibro.Size = new System.Drawing.Size(69, 24);
            this.rbLibro.TabIndex = 0;
            this.rbLibro.TabStop = true;
            this.rbLibro.Text = "Libro";
            this.rbLibro.UseVisualStyleBackColor = true;
            this.rbLibro.CheckedChanged += new System.EventHandler(this.rbLibro_CheckedChanged);
            // 
            // rbLibroMaterialDigital
            // 
            this.rbLibroMaterialDigital.AutoSize = true;
            this.rbLibroMaterialDigital.Location = new System.Drawing.Point(24, 56);
            this.rbLibroMaterialDigital.Name = "rbLibroMaterialDigital";
            this.rbLibroMaterialDigital.Size = new System.Drawing.Size(138, 44);
            this.rbLibroMaterialDigital.TabIndex = 1;
            this.rbLibroMaterialDigital.Text = "Libro +\r\nMaterial Digital\r\n";
            this.rbLibroMaterialDigital.UseVisualStyleBackColor = true;
            this.rbLibroMaterialDigital.CheckedChanged += new System.EventHandler(this.rbLibro_CheckedChanged);
            // 
            // rbRevista
            // 
            this.rbRevista.AutoSize = true;
            this.rbRevista.Location = new System.Drawing.Point(24, 106);
            this.rbRevista.Name = "rbRevista";
            this.rbRevista.Size = new System.Drawing.Size(87, 24);
            this.rbRevista.TabIndex = 2;
            this.rbRevista.Text = "Revista";
            this.rbRevista.UseVisualStyleBackColor = true;
            this.rbRevista.CheckedChanged += new System.EventHandler(this.rbLibro_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Controls.Add(this.chBoxPrimeraVez);
            this.groupBox3.Controls.Add(this.dtpkFechaNacimiento);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lsbCliente);
            this.groupBox3.Location = new System.Drawing.Point(13, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 476);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
            // 
            // lsbCliente
            // 
            this.lsbCliente.FormattingEnabled = true;
            this.lsbCliente.HorizontalScrollbar = true;
            this.lsbCliente.ItemHeight = 20;
            this.lsbCliente.Location = new System.Drawing.Point(19, 26);
            this.lsbCliente.Name = "lsbCliente";
            this.lsbCliente.Size = new System.Drawing.Size(580, 224);
            this.lsbCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(319, 265);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(319, 306);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Nacimiento :";
            // 
            // dtpkFechaNacimiento
            // 
            this.dtpkFechaNacimiento.Location = new System.Drawing.Point(319, 347);
            this.dtpkFechaNacimiento.Name = "dtpkFechaNacimiento";
            this.dtpkFechaNacimiento.Size = new System.Drawing.Size(280, 26);
            this.dtpkFechaNacimiento.TabIndex = 8;
            // 
            // chBoxPrimeraVez
            // 
            this.chBoxPrimeraVez.AutoSize = true;
            this.chBoxPrimeraVez.Location = new System.Drawing.Point(319, 390);
            this.chBoxPrimeraVez.Name = "chBoxPrimeraVez";
            this.chBoxPrimeraVez.Size = new System.Drawing.Size(121, 24);
            this.chBoxPrimeraVez.TabIndex = 9;
            this.chBoxPrimeraVez.Text = "Primera Vez";
            this.chBoxPrimeraVez.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(508, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 35);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPrestamos);
            this.groupBox4.Location = new System.Drawing.Point(650, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 439);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prestamos";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.HorizontalScrollbar = true;
            this.lstPrestamos.ItemHeight = 20;
            this.lstPrestamos.Location = new System.Drawing.Point(23, 27);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(580, 384);
            this.lstPrestamos.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCompletarPrestano);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.lsbEjemplaresCliente);
            this.groupBox5.Location = new System.Drawing.Point(650, 489);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(627, 420);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prestamo - Cliente";
            // 
            // lsbEjemplaresCliente
            // 
            this.lsbEjemplaresCliente.FormattingEnabled = true;
            this.lsbEjemplaresCliente.HorizontalScrollbar = true;
            this.lsbEjemplaresCliente.ItemHeight = 20;
            this.lsbEjemplaresCliente.Location = new System.Drawing.Point(23, 27);
            this.lsbEjemplaresCliente.Name = "lsbEjemplaresCliente";
            this.lsbEjemplaresCliente.Size = new System.Drawing.Size(580, 244);
            this.lsbEjemplaresCliente.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAgregar);
            this.groupBox6.Location = new System.Drawing.Point(23, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ejemplar - Seleccionado";
            // 
            // btnCompletarPrestano
            // 
            this.btnCompletarPrestano.Location = new System.Drawing.Point(418, 313);
            this.btnCompletarPrestano.Name = "btnCompletarPrestano";
            this.btnCompletarPrestano.Size = new System.Drawing.Size(173, 34);
            this.btnCompletarPrestano.TabIndex = 3;
            this.btnCompletarPrestano.Text = "Completar Prestamo";
            this.btnCompletarPrestano.UseVisualStyleBackColor = true;
            this.btnCompletarPrestano.Click += new System.EventHandler(this.btnCompletarPrestano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1315, 642);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbEjemplares;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRevista;
        private System.Windows.Forms.RadioButton rbLibroMaterialDigital;
        private System.Windows.Forms.RadioButton rbLibro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsbCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBoxPrimeraVez;
        private System.Windows.Forms.DateTimePicker dtpkFechaNacimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lsbEjemplaresCliente;
        private System.Windows.Forms.Button btnCompletarPrestano;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

