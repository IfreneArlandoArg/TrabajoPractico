using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
   
    public class GestorSalas : IGestorSalas
    {
        private List<Sala> salas;

        public GestorSalas()
        {
            salas = new List<Sala>
        {
            new Lactarios(),
            new Deambuladores(),
            new DeambuladoresII(),
            new SalaDe2(),
            new SalaDe3()
        };
        }

        public void InscribirAlumno(Alumno alumno, Sala sala)
        {
            sala.AgregarAlumno(alumno);
        }

        public void BajaAlumno(Alumno alumno, Sala sala)
        {
            sala.RemoverAlumno(alumno);
        }

        public List<Alumno> ObtenerAlumnosPorSala(Sala sala)
        {
            return sala.Alumnos;
        }

        public Sala ObtenerSalaConMayorCupo()
        {
            return salas.OrderByDescending(s => s.CupoActual).FirstOrDefault();
        }
    }

}
