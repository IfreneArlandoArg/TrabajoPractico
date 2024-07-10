using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
 
    public class GestorMaestras : IGestorMaestras
    {
        private List<Maestra> maestras;

        public GestorMaestras()
        {
            maestras = new List<Maestra>();
        }

        public void AgregarMaestra(Maestra maestra)
        {
            maestras.Add(maestra);
        }

        public void EliminarMaestra(Maestra maestra)
        {
            maestras.Remove(maestra);
        }

        public List<Maestra> ObtenerMaestras()
        {
            return maestras;
        }
    }

}
