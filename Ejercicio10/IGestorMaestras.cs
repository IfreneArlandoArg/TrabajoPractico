using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public interface IGestorMaestras
    {
        void AgregarMaestra(Maestra maestra);
        void EliminarMaestra(Maestra maestra);
        List<Maestra> ObtenerMaestras();
    }

}
