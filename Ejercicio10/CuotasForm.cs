using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
   
    public partial class CuotasForm : Form
    {
        private IGestorCuotas gestorCuotas;

        public CuotasForm(IGestorCuotas gestorCuotas)
        {
            InitializeComponent();
            this.gestorCuotas = gestorCuotas;
        }

        private void btnCobrarCuotas_Click(object sender, EventArgs e)
        {
            gestorCuotas.GestionarCobroCuotas();
        }

        private void btnCalcularRecaudacion_Click(object sender, EventArgs e)
        {
            decimal recaudacion = gestorCuotas.CalcularRecaudacionMensual();
            MessageBox.Show($"Recaudación mensual: {recaudacion:C}");
        }

        private void btnCalcularGanancia_Click(object sender, EventArgs e)
        {
            decimal ganancia = gestorCuotas.CalcularGananciaMensual();
            MessageBox.Show($"Ganancia mensual: {ganancia:C}");
        }
    }

}
