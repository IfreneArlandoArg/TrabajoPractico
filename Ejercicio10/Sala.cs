using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    using System;
    using System.Collections.Generic;

    public abstract class Sala
    {
        public string Nombre { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoActual { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Maestra> Maestras { get; set; }

        public event EventHandler SalaLlena;

        public Sala(string nombre, int cupoMaximo, int cupoActual)
        {
            Nombre = nombre;
            CupoMaximo = cupoMaximo;
            CupoActual = cupoActual;
            Alumnos = new List<Alumno>();
            Maestras = new List<Maestra>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            if (CupoActual >= CupoMaximo)
            {
                SalaLlena?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Alumnos.Add(alumno);
                CupoActual++;
            }
        }

        public void RemoverAlumno(Alumno alumno)
        {
            Alumnos.Remove(alumno);
            CupoActual--;
        }
    }


    public class Lactarios : Sala
    {
        public Lactarios() : base("Lactarios", 12, 0)
        {
        }
    }

    public class Deambuladores : Sala
    {
        public Deambuladores() : base("Deambuladores", 15, 0)
        {
        }
    }

    public class DeambuladoresII : Sala
    {
        public DeambuladoresII() : base("Deambuladores II", 15, 0)
        {
        }
    }

    public class SalaDe2 : Sala
    {
        public SalaDe2() : base("Sala de 2", 18, 0)
        {
        }
    }

    public class SalaDe3 : Sala
    {
        public SalaDe3() : base("Sala de 3", 20, 0)
        {
        }
    }



}
