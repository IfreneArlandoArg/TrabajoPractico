namespace Ejercicio_11
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
            this.lstbMedicos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoBaseMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarMedico = new System.Windows.Forms.Button();
            this.btnGananciaTotal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstbEspecialidades = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstbPacientes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lstHistorFechaDescendiente = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lstbFiltradaEspecialidad = new System.Windows.Forms.ListBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstbMedicos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicos ";
            // 
            // lstbMedicos
            // 
            this.lstbMedicos.FormattingEnabled = true;
            this.lstbMedicos.HorizontalScrollbar = true;
            this.lstbMedicos.ItemHeight = 20;
            this.lstbMedicos.Location = new System.Drawing.Point(10, 26);
            this.lstbMedicos.Name = "lstbMedicos";
            this.lstbMedicos.Size = new System.Drawing.Size(492, 264);
            this.lstbMedicos.TabIndex = 0;
            this.lstbMedicos.SelectedIndexChanged += new System.EventHandler(this.lstbMedicos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbEspecialidad);
            this.groupBox2.Controls.Add(this.btnCargarMedico);
            this.groupBox2.Controls.Add(this.txtNombreMedico);
            this.groupBox2.Controls.Add(this.txtCostoBaseMedico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo base :";
            // 
            // txtCostoBaseMedico
            // 
            this.txtCostoBaseMedico.Location = new System.Drawing.Point(133, 64);
            this.txtCostoBaseMedico.Name = "txtCostoBaseMedico";
            this.txtCostoBaseMedico.Size = new System.Drawing.Size(343, 26);
            this.txtCostoBaseMedico.TabIndex = 1;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(133, 29);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(343, 26);
            this.txtNombreMedico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            // 
            // btnCargarMedico
            // 
            this.btnCargarMedico.Location = new System.Drawing.Point(390, 109);
            this.btnCargarMedico.Name = "btnCargarMedico";
            this.btnCargarMedico.Size = new System.Drawing.Size(84, 35);
            this.btnCargarMedico.TabIndex = 2;
            this.btnCargarMedico.Text = "Cargar";
            this.btnCargarMedico.UseVisualStyleBackColor = true;
            this.btnCargarMedico.Click += new System.EventHandler(this.btnCargarMedico_Click);
            // 
            // btnGananciaTotal
            // 
            this.btnGananciaTotal.Location = new System.Drawing.Point(890, 330);
            this.btnGananciaTotal.Name = "btnGananciaTotal";
            this.btnGananciaTotal.Size = new System.Drawing.Size(161, 35);
            this.btnGananciaTotal.TabIndex = 4;
            this.btnGananciaTotal.Text = "Ganancia Total";
            this.btnGananciaTotal.UseVisualStyleBackColor = true;
            this.btnGananciaTotal.Click += new System.EventHandler(this.btnGananciaTotal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstbEspecialidades);
            this.groupBox3.Location = new System.Drawing.Point(549, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 302);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Especialidades";
            // 
            // lstbEspecialidades
            // 
            this.lstbEspecialidades.FormattingEnabled = true;
            this.lstbEspecialidades.ItemHeight = 20;
            this.lstbEspecialidades.Location = new System.Drawing.Point(10, 26);
            this.lstbEspecialidades.Name = "lstbEspecialidades";
            this.lstbEspecialidades.Size = new System.Drawing.Size(492, 264);
            this.lstbEspecialidades.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.lstbPacientes);
            this.groupBox5.Location = new System.Drawing.Point(13, 533);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1049, 601);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pacientes ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.txtNombrePaciente);
            this.groupBox6.Controls.Add(this.txtDniPaciente);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(10, 297);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(492, 273);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paciente";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cargar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(133, 29);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(343, 26);
            this.txtNombrePaciente.TabIndex = 3;
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(133, 64);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(343, 26);
            this.txtDniPaciente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre :";
            // 
            // lstbPacientes
            // 
            this.lstbPacientes.FormattingEnabled = true;
            this.lstbPacientes.HorizontalScrollbar = true;
            this.lstbPacientes.ItemHeight = 20;
            this.lstbPacientes.Location = new System.Drawing.Point(10, 26);
            this.lstbPacientes.Name = "lstbPacientes";
            this.lstbPacientes.Size = new System.Drawing.Size(492, 264);
            this.lstbPacientes.TabIndex = 0;
            this.lstbPacientes.SelectedIndexChanged += new System.EventHandler(this.lstbPacientes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Nacimiento :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(530, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(508, 544);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Historial Clinica - Paciente";
            // 
            // lstHistorFechaDescendiente
            // 
            this.lstHistorFechaDescendiente.FormattingEnabled = true;
            this.lstHistorFechaDescendiente.HorizontalScrollbar = true;
            this.lstHistorFechaDescendiente.ItemHeight = 20;
            this.lstHistorFechaDescendiente.Location = new System.Drawing.Point(22, 25);
            this.lstHistorFechaDescendiente.Name = "lstHistorFechaDescendiente";
            this.lstHistorFechaDescendiente.Size = new System.Drawing.Size(432, 164);
            this.lstHistorFechaDescendiente.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lstHistorFechaDescendiente);
            this.groupBox8.Location = new System.Drawing.Point(16, 53);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(476, 221);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Descendiente Fecha";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lstbFiltradaEspecialidad);
            this.groupBox9.Location = new System.Drawing.Point(16, 280);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(476, 221);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filtrada por Especialidad";
            // 
            // lstbFiltradaEspecialidad
            // 
            this.lstbFiltradaEspecialidad.FormattingEnabled = true;
            this.lstbFiltradaEspecialidad.HorizontalScrollbar = true;
            this.lstbFiltradaEspecialidad.ItemHeight = 20;
            this.lstbFiltradaEspecialidad.Location = new System.Drawing.Point(22, 31);
            this.lstbFiltradaEspecialidad.Name = "lstbFiltradaEspecialidad";
            this.lstbFiltradaEspecialidad.Size = new System.Drawing.Size(432, 164);
            this.lstbFiltradaEspecialidad.TabIndex = 3;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(133, 109);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 28);
            this.cmbEspecialidad.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Especialidad :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.ClientSize = new System.Drawing.Size(1101, 860);
            this.Controls.Add(this.btnGananciaTotal);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstbMedicos;
        private System.Windows.Forms.TextBox txtCostoBaseMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGananciaTotal;
        private System.Windows.Forms.Button btnCargarMedico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstbEspecialidades;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstbPacientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox lstHistorFechaDescendiente;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox lstbFiltradaEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}

