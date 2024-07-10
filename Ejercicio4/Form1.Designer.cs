namespace Ejercicio4
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
            this.btnVender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbJarra = new System.Windows.Forms.RadioButton();
            this.rbVaso = new System.Windows.Forms.RadioButton();
            this.rbChopp = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNegraNacional = new System.Windows.Forms.RadioButton();
            this.rbRubiaNacional = new System.Windows.Forms.RadioButton();
            this.rbRubiaExtranjera = new System.Windows.Forms.RadioButton();
            this.gbVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.lsbVentasInfos);
            this.gbVentas.Location = new System.Drawing.Point(324, 21);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(427, 184);
            this.gbVentas.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbJarra);
            this.groupBox3.Controls.Add(this.rbVaso);
            this.groupBox3.Controls.Add(this.rbChopp);
            this.groupBox3.Location = new System.Drawing.Point(154, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos Vasos";
            // 
            // rbJarra
            // 
            this.rbJarra.AutoSize = true;
            this.rbJarra.Location = new System.Drawing.Point(20, 66);
            this.rbJarra.Name = "rbJarra";
            this.rbJarra.Size = new System.Drawing.Size(48, 17);
            this.rbJarra.TabIndex = 2;
            this.rbJarra.Text = "Jarra";
            this.rbJarra.UseVisualStyleBackColor = true;
            // 
            // rbVaso
            // 
            this.rbVaso.AutoSize = true;
            this.rbVaso.Location = new System.Drawing.Point(20, 43);
            this.rbVaso.Name = "rbVaso";
            this.rbVaso.Size = new System.Drawing.Size(49, 17);
            this.rbVaso.TabIndex = 1;
            this.rbVaso.Text = "Vaso";
            this.rbVaso.UseVisualStyleBackColor = true;
            // 
            // rbChopp
            // 
            this.rbChopp.AutoSize = true;
            this.rbChopp.Checked = true;
            this.rbChopp.Location = new System.Drawing.Point(20, 20);
            this.rbChopp.Name = "rbChopp";
            this.rbChopp.Size = new System.Drawing.Size(56, 17);
            this.rbChopp.TabIndex = 0;
            this.rbChopp.TabStop = true;
            this.rbChopp.Text = "Chopp";
            this.rbChopp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRubiaExtranjera);
            this.groupBox2.Controls.Add(this.rbNegraNacional);
            this.groupBox2.Controls.Add(this.rbRubiaNacional);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos Cervezas";
            // 
            // rbNegraNacional
            // 
            this.rbNegraNacional.AutoSize = true;
            this.rbNegraNacional.Location = new System.Drawing.Point(20, 43);
            this.rbNegraNacional.Name = "rbNegraNacional";
            this.rbNegraNacional.Size = new System.Drawing.Size(99, 17);
            this.rbNegraNacional.TabIndex = 1;
            this.rbNegraNacional.Text = "Negra Nacional";
            this.rbNegraNacional.UseVisualStyleBackColor = true;
            // 
            // rbRubiaNacional
            // 
            this.rbRubiaNacional.AutoSize = true;
            this.rbRubiaNacional.Checked = true;
            this.rbRubiaNacional.Location = new System.Drawing.Point(20, 20);
            this.rbRubiaNacional.Name = "rbRubiaNacional";
            this.rbRubiaNacional.Size = new System.Drawing.Size(98, 17);
            this.rbRubiaNacional.TabIndex = 0;
            this.rbRubiaNacional.TabStop = true;
            this.rbRubiaNacional.Text = "Rubia Nacional";
            this.rbRubiaNacional.UseVisualStyleBackColor = true;
            // 
            // rbRubiaExtranjera
            // 
            this.rbRubiaExtranjera.AutoSize = true;
            this.rbRubiaExtranjera.Location = new System.Drawing.Point(20, 68);
            this.rbRubiaExtranjera.Name = "rbRubiaExtranjera";
            this.rbRubiaExtranjera.Size = new System.Drawing.Size(103, 17);
            this.rbRubiaExtranjera.TabIndex = 2;
            this.rbRubiaExtranjera.Text = "Rubia Extranjera";
            this.rbRubiaExtranjera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 230);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "After Office ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVentas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.ListBox lsbVentasInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbJarra;
        private System.Windows.Forms.RadioButton rbVaso;
        private System.Windows.Forms.RadioButton rbChopp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRubiaExtranjera;
        private System.Windows.Forms.RadioButton rbNegraNacional;
        private System.Windows.Forms.RadioButton rbRubiaNacional;
    }
}

