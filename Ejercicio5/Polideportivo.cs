using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class Polideportivo
    {
        private List<Alquiler> alquileres;
        private List<Juez> jueces;

        public Polideportivo()
        {
            alquileres = new List<Alquiler>();
            jueces = new List<Juez>();
        }

        public void AgregarJuez(Juez juez)
        {
            jueces.Add(juez);
        }

        public bool AlquilarCancha(Cancha cancha, DateTime inicio, DateTime fin, List<Juez> juecesNecesarios)
        {
            var nuevoAlquiler = new Alquiler(cancha, inicio, fin);

            foreach (var alquiler in alquileres)
            {
                if (nuevoAlquiler.SeSuperpone(alquiler))
                {
                    return false; // No se puede alquilar porque hay superposición de horarios
                }

                foreach (var juez in juecesNecesarios)
                {
                    if (alquiler.Jueces.Contains(juez) && nuevoAlquiler.SeSuperpone(alquiler))
                    {
                        return false; // No se puede alquilar porque un juez está ocupado
                    }
                }
            }

            nuevoAlquiler.Jueces.AddRange(juecesNecesarios);
            foreach (var juez in juecesNecesarios)
            {
                juez.AgregarPartido(juez.Ganancia);
            }
            alquileres.Add(nuevoAlquiler);
            return true;
        }

        public double CalcularRecaudacionTotal()
        {
            return alquileres.Sum(a => a.Cancha.CalcularCostoTotal());
        }

        public double CalcularGananciaTotal()
        {
            return alquileres.Sum(a => a.Cancha.CalcularGananciaPolideportivo());
        }

        public Cancha ObtenerCanchaMasAlquilada()
        {
            List<Cancha> lstCancha = new List<Cancha>();

            foreach (Alquiler c in alquileres) 
            {
                lstCancha.Add(c.Cancha);
            }

            return lstCancha.OrderByDescending(p => p.CantVecesAlquilada).FirstOrDefault();

           

        }

        public Cancha ObtenerCanchaMasRecaudo()
        {
            List<Cancha> lstCancha = new List<Cancha>();

            foreach (Alquiler c in alquileres)
            {
                lstCancha.Add(c.Cancha);
            }

            return lstCancha.OrderByDescending(g => g.CalcularCostoTotal()).FirstOrDefault();

            
        }

        public Juez ObtenerJuezMasPartidosDirigidos()
        {
            return jueces.OrderByDescending(j => j.PartidosDirigidos).First();
        }

        public Juez ObtenerJuezMayorGanancia()
        {
            return jueces.OrderByDescending(j => j.Ganancia).First();
        }
    }
}