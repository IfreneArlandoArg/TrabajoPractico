namespace Ejercicio3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbArabigo = new System.Windows.Forms.RadioButton();
            this.rbRobusto = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMediano = new System.Windows.Forms.RadioButton();
            this.rbChico = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.btnVender = new System.Windows.Forms.Button();
            this.lsbVentasInfos = new System.Windows.Forms.ListBox();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRobusto);
            this.groupBox2.Controls.Add(this.rbArabigo);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos Cafés";
            // 
            // rbArabigo
            // 
            this.rbArabigo.AutoSize = true;
            this.rbArabigo.Checked = true;
            this.rbArabigo.Location = new System.Drawing.Point(20, 20);
            this.rbArabigo.Name = "rbArabigo";
            this.rbArabigo.Size = new System.Drawing.Size(61, 17);
            this.rbArabigo.TabIndex = 0;
            this.rbArabigo.TabStop = true;
            this.rbArabigo.Text = "Arabigo";
            this.rbArabigo.UseVisualStyleBackColor = true;
            // 
            // rbRobusto
            // 
            this.rbRobusto.AutoSize = true;
            this.rbRobusto.Location = new System.Drawing.Point(20, 43);
            this.rbRobusto.Name = "rbRobusto";
            this.rbRobusto.Size = new System.Drawing.Size(65, 17);
            this.rbRobusto.TabIndex = 1;
            this.rbRobusto.Text = "Robusto";
            this.rbRobusto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbGrande);
            this.groupBox3.Controls.Add(this.rbMediano);
            this.groupBox3.Controls.Add(this.rbChico);
            this.groupBox3.Location = new System.Drawing.Point(154, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos Vasos";
            // 
            // rbMediano
            // 
            this.rbMediano.AutoSize = true;
            this.rbMediano.Location = new System.Drawing.Point(20, 43);
            this.rbMediano.Name = "rbMediano";
            this.rbMediano.Size = new System.Drawing.Size(66, 17);
            this.rbMediano.TabIndex = 1;
            this.rbMediano.Text = "Mediano";
            this.rbMediano.UseVisualStyleBackColor = true;
            // 
            // rbChico
            // 
            this.rbChico.AutoSize = true;
            this.rbChico.Checked = true;
            this.rbChico.Location = new System.Drawing.Point(20, 20);
            this.rbChico.Name = "rbChico";
            this.rbChico.Size = new System.Drawing.Size(52, 17);
            this.rbChico.TabIndex = 0;
            this.rbChico.TabStop = true;
            this.rbChico.Text = "Chico";
            this.rbChico.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(20, 66);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 2;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(105, 145);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lsbVentasInfos
            // 
            this.lsbVentasInfos.FormattingEnabled = true;
            this.lsbVentasInfos.Location = new System.Drawing.Point(27, 30);
            this.lsbVentasInfos.Name = "lsbVentasInfos";
            this.lsbVentasInfos.Size = new System.Drawing.Size(378, 134);
            this.lsbVentasInfos.TabIndex = 1;
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.lsbVentasInfos);
            this.gbVentas.Location = new System.Drawing.Point(323, 23);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(427, 184);
            this.gbVentas.TabIndex = 2;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cafeteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbArabigo;
        private System.Windows.Forms.RadioButton rbRobusto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMediano;
        private System.Windows.Forms.RadioButton rbChico;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ListBox lsbVentasInfos;
        private System.Windows.Forms.GroupBox gbVentas;
    }
}

