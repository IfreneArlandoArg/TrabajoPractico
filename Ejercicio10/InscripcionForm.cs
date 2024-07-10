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
    
    public partial class InscripcionForm : Form
    {
        private IGestorSalas gestorSalas;

        public InscripcionForm(IGestorSalas gestorSalas)
        {
            InitializeComponent();
            this.gestorSalas = gestorSalas;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            // Lógica para inscribir un alumno
        }
    }

}
