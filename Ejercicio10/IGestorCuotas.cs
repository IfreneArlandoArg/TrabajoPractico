using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public interface IGestorCuotas
    {
        void GestionarCobroCuotas();
        decimal CalcularRecaudacionMensual();
        decimal CalcularGananciaMensual();
        void ImprimirCuota(Alumno alumno);
    }

}
