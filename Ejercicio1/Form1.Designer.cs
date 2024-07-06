using System;

namespace Ejercicio1
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
            this.dtgvProductoVenta = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbHistorialVenta = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductoVenta)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCompletar);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.dtgvProductoVenta);
            this.groupBox1.Location = new System.Drawing.Point(649, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrito Producto(s) Venta";
            // 
            // dtgvProductoVenta
            // 
            this.dtgvProductoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductoVenta.Location = new System.Drawing.Point(17, 36);
            this.dtgvProductoVenta.Name = "dtgvProductoVenta";
            this.dtgvProductoVenta.RowHeadersWidth = 62;
            this.dtgvProductoVenta.RowTemplate.Height = 28;
            this.dtgvProductoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductoVenta.Size = new System.Drawing.Size(488, 191);
            this.dtgvProductoVenta.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(419, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(27, 245);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 39);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(27, 300);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(109, 39);
            this.btnCompletar.TabIndex = 4;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(981, 604);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(141, 39);
            this.btnInstrucciones.TabIndex = 5;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(173, 36);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(353, 26);
            this.txtCodigoBarra.TabIndex = 6;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.label2);
            this.gbProducto.Controls.Add(this.btnAgregar);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Controls.Add(this.txtNombreProducto);
            this.gbProducto.Controls.Add(this.lblCodigoBarra);
            this.gbProducto.Controls.Add(this.txtCodigoBarra);
            this.gbProducto.Location = new System.Drawing.Point(12, 32);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(600, 294);
            this.gbProducto.TabIndex = 7;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(20, 38);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(114, 20);
            this.lblCodigoBarra.TabIndex = 7;
            this.lblCodigoBarra.Text = "Código Barra : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Producto : ";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(175, 77);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(353, 26);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcíón : ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(175, 119);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(353, 26);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio : ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(175, 162);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(353, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbHistorialVenta);
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 260);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial Venta";
            // 
            // lstbHistorialVenta
            // 
            this.lstbHistorialVenta.FormattingEnabled = true;
            this.lstbHistorialVenta.ItemHeight = 20;
            this.lstbHistorialVenta.Location = new System.Drawing.Point(16, 26);
            this.lstbHistorialVenta.Name = "lstbHistorialVenta";
            this.lstbHistorialVenta.Size = new System.Drawing.Size(560, 204);
            this.lstbHistorialVenta.TabIndex = 0;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(649, 419);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(219, 39);
            this.btnRecaudacion.TabIndex = 9;
            this.btnRecaudacion.Text = "Recaudación Total";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(342, 252);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(163, 26);
            this.txtSubtotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subtotal : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 705);
            this.Controls.Add(this.btnRecaudacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ej1_GestionVentaProducto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductoVenta)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgvProductoVenta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstbHistorialVenta;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label4;
    }
}

