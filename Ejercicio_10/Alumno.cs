using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneHermano { get; set; }
        public double Cuota { get; set; }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, bool tieneHermano,TipoInscripcion tipoInscripcion)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            TieneHermano = tieneHermano;
            Cuota = CalcularCuota(tieneHermano, tipoInscripcion);

        }

        public double CalcularCuota(bool tieneHermano, TipoInscripcion tipoInscripcion)
        {
            double cuotaBase = 0;
            switch (tipoInscripcion)
            {
                case TipoInscripcion.CuotaBase:
                    cuotaBase = 100000;
                    break;
                case TipoInscripcion.CuotaDoble:
                    cuotaBase = 175000; // 75% más caro
                    break;
                case TipoInscripcion.CuotaDobleConComedor:
                    cuotaBase = 200000;
                    break;
            }

            if (tieneHermano)
            {
                cuotaBase *= 0.6; // Descuento del 40%
            }

            return cuotaBase;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}";
        }
    }

}
