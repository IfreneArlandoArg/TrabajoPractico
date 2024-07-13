using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    using System;
    using System.Collections.Generic;

    public class Sala
    {
        public string Nombre { get; set; }
        public int Cupo { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Maestra> Maestras { get; set; }

        public Sala(string nombre, int cupo, int edadMinima, int edadMaxima)
        {
            Nombre = nombre;
            Cupo = cupo;
            EdadMinima = edadMinima;
            EdadMaxima = edadMaxima;

            Alumnos = new List<Alumno>();
            Maestras = new List<Maestra>();
        }

        public bool InscribirAlumno(Alumno alumno)
        {
            if (Alumnos.Count >= Cupo)
            {
                OnSalaSinCupo(new EventArgs());
                return false;
            }
            Alumnos.Add(alumno);
            

            return true;
        }

        public void BajaAlumno(Alumno alumno)
        {
            Alumnos.Remove(alumno);
        }

        public event EventHandler SalaSinCupo;

        protected virtual void OnSalaSinCupo(EventArgs e)
        {
            SalaSinCupo?.Invoke(this, e);
        }

       
        public override string ToString()
        {
            return Nombre;
        }
    }

}
