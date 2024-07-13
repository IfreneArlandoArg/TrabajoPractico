namespace Ejercicio_10
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chbTieneHermano = new System.Windows.Forms.CheckBox();
            this.gbMaestras = new System.Windows.Forms.GroupBox();
            this.dtgvMaestras = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbCuota_Base = new System.Windows.Forms.RadioButton();
            this.rbCuotaDoble = new System.Windows.Forms.RadioButton();
            this.rbCuotaDobleConComedor = new System.Windows.Forms.RadioButton();
            this.btnRecaudacionMensual = new System.Windows.Forms.Button();
            this.btnGannaciaMensual = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtgvAlumnosJardin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbMaestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestras)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnosJardin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSalas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salas";
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 20;
            this.lstSalas.Location = new System.Drawing.Point(21, 25);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(509, 204);
            this.lstSalas.TabIndex = 0;
            this.lstSalas.SelectedIndexChanged += new System.EventHandler(this.lstSalas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(586, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alumnos";
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 20;
            this.lstAlumnos.Location = new System.Drawing.Point(16, 25);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(251, 204);
            this.lstAlumnos.TabIndex = 0;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(639, 213);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(84, 35);
            this.btnInscribir.TabIndex = 1;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(183, 235);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(84, 35);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.chbTieneHermano);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.btnInscribir);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(586, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 272);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(308, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(308, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Nacimiento :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // chbTieneHermano
            // 
            this.chbTieneHermano.AutoSize = true;
            this.chbTieneHermano.Location = new System.Drawing.Point(232, 167);
            this.chbTieneHermano.Name = "chbTieneHermano";
            this.chbTieneHermano.Size = new System.Drawing.Size(208, 24);
            this.chbTieneHermano.TabIndex = 6;
            this.chbTieneHermano.Text = "Tiene Hermano en jardín";
            this.chbTieneHermano.UseVisualStyleBackColor = true;
            // 
            // gbMaestras
            // 
            this.gbMaestras.Controls.Add(this.dtgvMaestras);
            this.gbMaestras.Location = new System.Drawing.Point(13, 330);
            this.gbMaestras.Name = "gbMaestras";
            this.gbMaestras.Size = new System.Drawing.Size(547, 272);
            this.gbMaestras.TabIndex = 1;
            this.gbMaestras.TabStop = false;
            this.gbMaestras.Text = "Maestras";
            // 
            // dtgvMaestras
            // 
            this.dtgvMaestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaestras.Location = new System.Drawing.Point(21, 38);
            this.dtgvMaestras.Name = "dtgvMaestras";
            this.dtgvMaestras.RowHeadersWidth = 62;
            this.dtgvMaestras.RowTemplate.Height = 28;
            this.dtgvMaestras.Size = new System.Drawing.Size(509, 210);
            this.dtgvMaestras.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbCuotaDobleConComedor);
            this.groupBox4.Controls.Add(this.rbCuotaDoble);
            this.groupBox4.Controls.Add(this.rbCuota_Base);
            this.groupBox4.Location = new System.Drawing.Point(550, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 148);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo Inscripción";
            // 
            // rbCuota_Base
            // 
            this.rbCuota_Base.AutoSize = true;
            this.rbCuota_Base.Checked = true;
            this.rbCuota_Base.Location = new System.Drawing.Point(21, 29);
            this.rbCuota_Base.Name = "rbCuota_Base";
            this.rbCuota_Base.Size = new System.Drawing.Size(118, 24);
            this.rbCuota_Base.TabIndex = 0;
            this.rbCuota_Base.TabStop = true;
            this.rbCuota_Base.Text = "Cuota Base";
            this.rbCuota_Base.UseVisualStyleBackColor = true;
            // 
            // rbCuotaDoble
            // 
            this.rbCuotaDoble.AutoSize = true;
            this.rbCuotaDoble.Location = new System.Drawing.Point(21, 60);
            this.rbCuotaDoble.Name = "rbCuotaDoble";
            this.rbCuotaDoble.Size = new System.Drawing.Size(123, 24);
            this.rbCuotaDoble.TabIndex = 1;
            this.rbCuotaDoble.Text = "Cuota Doble";
            this.rbCuotaDoble.UseVisualStyleBackColor = true;
            // 
            // rbCuotaDobleConComedor
            // 
            this.rbCuotaDobleConComedor.AutoSize = true;
            this.rbCuotaDobleConComedor.Location = new System.Drawing.Point(21, 93);
            this.rbCuotaDobleConComedor.Name = "rbCuotaDobleConComedor";
            this.rbCuotaDobleConComedor.Size = new System.Drawing.Size(132, 44);
            this.rbCuotaDobleConComedor.TabIndex = 2;
            this.rbCuotaDobleConComedor.Text = "CuotaDoble +\r\nComedor";
            this.rbCuotaDobleConComedor.UseVisualStyleBackColor = true;
            // 
            // btnRecaudacionMensual
            // 
            this.btnRecaudacionMensual.Location = new System.Drawing.Point(884, 632);
            this.btnRecaudacionMensual.Name = "btnRecaudacionMensual";
            this.btnRecaudacionMensual.Size = new System.Drawing.Size(207, 35);
            this.btnRecaudacionMensual.TabIndex = 9;
            this.btnRecaudacionMensual.Text = "Recaudacion Mensual";
            this.btnRecaudacionMensual.UseVisualStyleBackColor = true;
            this.btnRecaudacionMensual.Click += new System.EventHandler(this.btnRecaudacionMensual_Click);
            // 
            // btnGannaciaMensual
            // 
            this.btnGannaciaMensual.Location = new System.Drawing.Point(1144, 632);
            this.btnGannaciaMensual.Name = "btnGannaciaMensual";
            this.btnGannaciaMensual.Size = new System.Drawing.Size(207, 35);
            this.btnGannaciaMensual.TabIndex = 10;
            this.btnGannaciaMensual.Text = "Gannacia Mensual";
            this.btnGannaciaMensual.UseVisualStyleBackColor = true;
            this.btnGannaciaMensual.Click += new System.EventHandler(this.btnGannaciaMensual_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBaja);
            this.groupBox5.Controls.Add(this.lstAlumnos);
            this.groupBox5.Location = new System.Drawing.Point(16, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 280);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sala Seleccionada";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtgvAlumnosJardin);
            this.groupBox6.Location = new System.Drawing.Point(306, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(433, 261);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jardin";
            // 
            // dtgvAlumnosJardin
            // 
            this.dtgvAlumnosJardin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnosJardin.Location = new System.Drawing.Point(25, 28);
            this.dtgvAlumnosJardin.Name = "dtgvAlumnosJardin";
            this.dtgvAlumnosJardin.ReadOnly = true;
            this.dtgvAlumnosJardin.RowHeadersWidth = 62;
            this.dtgvAlumnosJardin.RowTemplate.Height = 28;
            this.dtgvAlumnosJardin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAlumnosJardin.Size = new System.Drawing.Size(384, 210);
            this.dtgvAlumnosJardin.TabIndex = 1;
            this.dtgvAlumnosJardin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlumnosJardin_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 697);
            this.Controls.Add(this.btnGannaciaMensual);
            this.Controls.Add(this.btnRecaudacionMensual);
            this.Controls.Add(this.gbMaestras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbMaestras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestras)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnosJardin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbTieneHermano;
        private System.Windows.Forms.GroupBox gbMaestras;
        private System.Windows.Forms.DataGridView dtgvMaestras;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbCuota_Base;
        private System.Windows.Forms.RadioButton rbCuotaDobleConComedor;
        private System.Windows.Forms.RadioButton rbCuotaDoble;
        private System.Windows.Forms.Button btnRecaudacionMensual;
        private System.Windows.Forms.Button btnGannaciaMensual;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dtgvAlumnosJardin;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

