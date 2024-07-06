using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ventas ventas = new Ventas();

        Venta venta = new Venta();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Para Iniciar una venta\n\"Agregar\" Producto(s), Al terminar Haga click en \"Completar\" para registrar la compra.", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

      
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void resetTextBox() 
        {
            txtCodigoBarra.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;

        }

        private void MostrarDataGrid(DataGridView dtgv, object pO) 
        {
            dtgv.DataSource = null;
            dtgv.DataSource = pO;
        }
        private void MostrarlstBox(ListBox lstB, object pO)
        {
            lstB.DataSource = null;
            lstB.DataSource = pO;
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Para Iniciar una venta\n\"Agregar\" Producto(s), Al terminar Haga click en \"Completar\" para registrar la compra.","Instrucciones",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoBarra.Text == string.Empty)
                    throw new Exception("El producto tiene qué tener un codigo barra.");
                if (txtNombreProducto.Text == string.Empty)
                    throw new Exception("El producto tiene qué tener un Nombre");
                if (txtPrecio.Text == string.Empty)
                    throw new Exception("El producto tiene qué tener un Precio");



                

                double Precio;
                bool PrecioDouble = double.TryParse(txtPrecio.Text, out Precio);
               
                if (!PrecioDouble)
                    throw new Exception($"{txtPrecio.Text} tiene qué tener un valor númerico.");

                venta.AgregarProducto(new Producto(txtCodigoBarra.Text, txtNombreProducto.Text, txtDescripcion.Text, Precio));

                resetTextBox();

                MostrarDataGrid(dtgvProductoVenta, venta.GetProductos());

                txtSubtotal.Text = venta.SubTotal().ToString();

            }
            catch (Exception ex){ MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta.GetProductos().Count == 0)
                    throw new Exception("No hay productos a borrar...");

                if(dtgvProductoVenta.SelectedRows.Count == 0) 
                   throw new Exception("Tiene qué seleccionar un producto para borrar...");

                Producto pProducto = dtgvProductoVenta.CurrentRow.DataBoundItem as Producto;

                venta.BorrarProducto(pProducto);

                MostrarDataGrid(dtgvProductoVenta, venta.GetProductos());


                txtSubtotal.Text = venta.SubTotal().ToString();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta.GetProductos().Count == 0)
                    throw new Exception("Hay que agregar Productos al carrito para completar la venta...");


                ventas.AgregarVenta(venta);

                venta = new Venta();

                MostrarDataGrid(dtgvProductoVenta, venta.GetProductos());
                txtSubtotal.Text = venta.SubTotal().ToString();

                MostrarlstBox(lstbHistorialVenta, ventas.getVentas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cancelar
            try
            {
                venta.CancelarVenta();
                MostrarDataGrid(dtgvProductoVenta, venta.GetProductos());
                txtSubtotal.Text = venta.SubTotal().ToString();

                MessageBox.Show("Venta Cancelada!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"La recaudación total es de : {ventas.RecaudacionTotal()} ARS$");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
