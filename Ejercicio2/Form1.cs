using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Ventas ventas = new Ventas();

        void MostrarReporteVentas() 
        {
            lsbResultados.DataSource = null;
            lsbResultados.DataSource = ventas.getListdataReporteVentas();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = "Normal";
                
                int cantidadLitro;

                bool valorNumericoInt = int.TryParse(textBox1.Text, out cantidadLitro);

                if (!valorNumericoInt)
                    throw new Exception($"La cantidad \"{textBox1.Text}\" tiene qué ser un valor numerico de tipo Entero.");

                if (rbNormal.Checked)
                    tipo = rbNormal.Text;
                if (rbSuper.Checked) 
                    tipo = rbSuper.Text;
                if (rbPremium.Checked)
                    tipo = rbPremium.Text;

                if (!ventas.cantidadLitroDisponible(cantidadLitro, tipo))
                    throw new Exception($"Cantidad {cantidadLitro} no disponible ahora en {tipo}.");

                ventas.AddVenta( new Venta(cantidadLitro, tipo));

                MostrarReporteVentas();

                textBox1.Text = string.Empty;

            }
            catch (Exception ex){ MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }
    }
}
