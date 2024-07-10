using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
   

    public enum TipoCuota
    {
        Base,
        Doble,
        DobleConComedor
    }

    public class Cuota
    {
        public TipoCuota Tipo { get; set; }
        public decimal Monto { get; set; }
        public Alumno Alumno { get; set; }
        public Sala Sala { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Pagada { get; set; }

        public Cuota(TipoCuota tipo, decimal monto, Alumno alumno, Sala sala)
        {
            Tipo = tipo;
            Monto = monto;
            Alumno = alumno;
            Sala = sala;
            FechaPago = DateTime.Now;
            Pagada = false;
        }

        public decimal CalcularMontoFinal()
        {
            decimal montoFinal = Monto;

            switch (Tipo)
            {
                case TipoCuota.Doble:
                    montoFinal += Monto * 0.75m;
                    break;
                case TipoCuota.DobleConComedor:
                    montoFinal += Monto * 0.75m + 50; // Asumiendo 50 como el costo del comedor
                    break;
            }

            if (Alumno.TieneHermanoEnEstablecimiento)
            {
                montoFinal *= 0.60m; // Descuento del 40%
            }

            return montoFinal;
        }

        public override string ToString()
        {
            return $"{Alumno.Nombre} {Alumno.Apellido} - {Sala.Nombre} - {Tipo} - {Monto:C} - Pagada: {Pagada}";
        }
    }

}
