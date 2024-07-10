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
   
    public partial class MaestrasForm : Form
    {
        private IGestorMaestras gestorMaestras;

        public MaestrasForm(IGestorMaestras gestorMaestras)
        {
            InitializeComponent();
            this.gestorMaestras = gestorMaestras;
        }

        private void btnAgregarMaestra_Click(object sender, EventArgs e)
        {
            // Lógica para agregar una maestra
        }

        private void btnEliminarMaestra_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar una maestra
        }
    }

}
