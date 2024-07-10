using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public interface IGestorSalas
    {
        void InscribirAlumno(Alumno alumno, Sala sala);
        void BajaAlumno(Alumno alumno, Sala sala);
        List<Alumno> ObtenerAlumnosPorSala(Sala sala);
        Sala ObtenerSalaConMayorCupo();
    }

}
