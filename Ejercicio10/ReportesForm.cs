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
    
    public partial class ReportesForm : Form
    {
        private IGestorSalas gestorSalas;
        private IGestorCuotas gestorCuotas;

        public ReportesForm(IGestorSalas gestorSalas, IGestorCuotas gestorCuotas)
        {
            InitializeComponent();
            this.gestorSalas = gestorSalas;
            this.gestorCuotas = gestorCuotas;
        }

        private void btnImprimirListaAlumnos_Click(object sender, EventArgs e)
        {
            // Lógica para imprimir lista de alumnos
        }

        private void btnImprimirCuota_Click(object sender, EventArgs e)
        {
            // Lógica para imprimir cuota de un alumno seleccionado
        }
    }

}
