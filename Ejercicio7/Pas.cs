using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Pasaporte
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Atraccion> Atracciones { get; set; }

        public Pasaporte(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Atracciones = new List<Atraccion>();
        }

        public void AgregarAtraccion(Atraccion atraccion)
        {
            Atracciones.Add(atraccion);
            atraccion.RegistrarVisita();
        }

        public double CalcularCostoTotal()
        {
            double costoTotal = Atracciones.Sum(a => a.CostoBase);
            double descuento = 0;

            if (Atracciones.Count == 2)
            {
                descuento = 0.1;
            }
            else if (Atracciones.Count == 3)
            {
                descuento = 0.3;
            }

            costoTotal = costoTotal * (1 - descuento);

            if (DateTime.Now.Year - FechaNacimiento.Year > 65 || DateTime.Now.Year - FechaNacimiento.Year < 12)
            {
                costoTotal *= 0.5; // 50% de descuento para jubilados y menores de 12 años
            }

            return costoTotal;
        }

        public override string ToString()
        {
            return $"Pasaporte: {Nombre} {Apellido}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, Costo Total: {CalcularCostoTotal()}";
        }
    }
}
