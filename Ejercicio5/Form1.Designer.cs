namespace Ejercicio5
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
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.lsbVentasInfos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb3Arbitros = new System.Windows.Forms.RadioButton();
            this.rb1Arbitro = new System.Windows.Forms.RadioButton();
            this.rbCeroArbitro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCanchaFutbol7 = new System.Windows.Forms.RadioButton();
            this.rbCanchaFutbol5 = new System.Windows.Forms.RadioButton();
            this.rbCanchaTenis = new System.Windows.Forms.RadioButton();
            this.rbCanchaFutbol11 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.lsbVentasInfos);
            this.gbVentas.Location = new System.Drawing.Point(331, 22);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(427, 229);
            this.gbVentas.TabIndex = 6;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // lsbVentasInfos
            // 
            this.lsbVentasInfos.FormattingEnabled = true;
            this.lsbVentasInfos.Location = new System.Drawing.Point(27, 30);
            this.lsbVentasInfos.Name = "lsbVentasInfos";
            this.lsbVentasInfos.Size = new System.Drawing.Size(378, 134);
            this.lsbVentasInfos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnReservar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 319);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alquiler";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(102, 290);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb3Arbitros);
            this.groupBox3.Controls.Add(this.rb1Arbitro);
            this.groupBox3.Controls.Add(this.rbCeroArbitro);
            this.groupBox3.Location = new System.Drawing.Point(154, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arbitro";
            // 
            // rb3Arbitros
            // 
            this.rb3Arbitros.AutoSize = true;
            this.rb3Arbitros.Location = new System.Drawing.Point(20, 66);
            this.rb3Arbitros.Name = "rb3Arbitros";
            this.rb3Arbitros.Size = new System.Drawing.Size(94, 17);
            this.rb3Arbitros.TabIndex = 2;
            this.rb3Arbitros.Text = "1 + 2 de lineas";
            this.rb3Arbitros.UseVisualStyleBackColor = true;
            // 
            // rb1Arbitro
            // 
            this.rb1Arbitro.AutoSize = true;
            this.rb1Arbitro.Location = new System.Drawing.Point(20, 43);
            this.rb1Arbitro.Name = "rb1Arbitro";
            this.rb1Arbitro.Size = new System.Drawing.Size(66, 17);
            this.rb1Arbitro.TabIndex = 1;
            this.rb1Arbitro.Text = "1 central";
            this.rb1Arbitro.UseVisualStyleBackColor = true;
            // 
            // rbCeroArbitro
            // 
            this.rbCeroArbitro.AutoSize = true;
            this.rbCeroArbitro.Checked = true;
            this.rbCeroArbitro.Location = new System.Drawing.Point(20, 20);
            this.rbCeroArbitro.Name = "rbCeroArbitro";
            this.rbCeroArbitro.Size = new System.Drawing.Size(65, 17);
            this.rbCeroArbitro.TabIndex = 0;
            this.rbCeroArbitro.TabStop = true;
            this.rbCeroArbitro.Text = "Ninguno";
            this.rbCeroArbitro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCanchaFutbol11);
            this.groupBox2.Controls.Add(this.rbCanchaFutbol7);
            this.groupBox2.Controls.Add(this.rbCanchaFutbol5);
            this.groupBox2.Controls.Add(this.rbCanchaTenis);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canchas";
            // 
            // rbCanchaFutbol7
            // 
            this.rbCanchaFutbol7.AutoSize = true;
            this.rbCanchaFutbol7.Location = new System.Drawing.Point(20, 68);
            this.rbCanchaFutbol7.Name = "rbCanchaFutbol7";
            this.rbCanchaFutbol7.Size = new System.Drawing.Size(63, 17);
            this.rbCanchaFutbol7.TabIndex = 2;
            this.rbCanchaFutbol7.Text = "Futbol 7";
            this.rbCanchaFutbol7.UseVisualStyleBackColor = true;
            // 
            // rbCanchaFutbol5
            // 
            this.rbCanchaFutbol5.AutoSize = true;
            this.rbCanchaFutbol5.Location = new System.Drawing.Point(20, 43);
            this.rbCanchaFutbol5.Name = "rbCanchaFutbol5";
            this.rbCanchaFutbol5.Size = new System.Drawing.Size(63, 17);
            this.rbCanchaFutbol5.TabIndex = 1;
            this.rbCanchaFutbol5.Text = "Futbol 5";
            this.rbCanchaFutbol5.UseVisualStyleBackColor = true;
            // 
            // rbCanchaTenis
            // 
            this.rbCanchaTenis.AutoSize = true;
            this.rbCanchaTenis.Checked = true;
            this.rbCanchaTenis.Location = new System.Drawing.Point(20, 20);
            this.rbCanchaTenis.Name = "rbCanchaTenis";
            this.rbCanchaTenis.Size = new System.Drawing.Size(51, 17);
            this.rbCanchaTenis.TabIndex = 0;
            this.rbCanchaTenis.TabStop = true;
            this.rbCanchaTenis.Text = "Tenis";
            this.rbCanchaTenis.UseVisualStyleBackColor = true;
            // 
            // rbCanchaFutbol11
            // 
            this.rbCanchaFutbol11.AutoSize = true;
            this.rbCanchaFutbol11.Location = new System.Drawing.Point(20, 94);
            this.rbCanchaFutbol11.Name = "rbCanchaFutbol11";
            this.rbCanchaFutbol11.Size = new System.Drawing.Size(69, 17);
            this.rbCanchaFutbol11.TabIndex = 3;
            this.rbCanchaFutbol11.Text = "Futbol 11";
            this.rbCanchaFutbol11.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(7, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 379);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Polideportivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVentas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.ListBox lsbVentasInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb3Arbitros;
        private System.Windows.Forms.RadioButton rb1Arbitro;
        private System.Windows.Forms.RadioButton rbCeroArbitro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCanchaFutbol11;
        private System.Windows.Forms.RadioButton rbCanchaFutbol7;
        private System.Windows.Forms.RadioButton rbCanchaFutbol5;
        private System.Windows.Forms.RadioButton rbCanchaTenis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

