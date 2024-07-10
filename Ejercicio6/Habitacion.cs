using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public abstract class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double CostoPorNoche { get; set; }
        public bool VistaAlMar { get; set; }
        public List<string> Artefactos { get; set; }

        protected Habitacion(int numero, string tipo, double costoPorNoche, bool vistaAlMar)
        {
            Numero = numero;
            Tipo = tipo;
            CostoPorNoche = costoPorNoche;
            VistaAlMar = vistaAlMar;
            Artefactos = new List<string>();
        }

        public double CalcularCostoTotal(int noches, bool cuna)
        {
            double costoTotal = CostoPorNoche * noches;
            if (VistaAlMar)
            {
                costoTotal *= 0.85; // 15% de descuento por vista al mar
            }
            if (cuna)
            {
                costoTotal += 50 * noches; // Adicional por cuna
            }
            return costoTotal;
        }
    }

    public class HabitacionSimple : Habitacion
    {
        public HabitacionSimple(int numero, bool vistaAlMar)
            : base(numero, "Simple", 200, vistaAlMar) { }
    }

    public class HabitacionDobleMatrimonial : Habitacion
    {
        public HabitacionDobleMatrimonial(int numero, bool vistaAlMar)
            : base(numero, "Doble Matrimonial", 350, vistaAlMar) { }
    }

    public class HabitacionTriple : Habitacion
    {
        public HabitacionTriple(int numero, bool vistaAlMar)
            : base(numero, "Triple", 550, vistaAlMar) { }
    }

    public class HabitacionCuadruple : Habitacion
    {
        public HabitacionCuadruple(int numero, bool vistaAlMar)
            : base(numero, "Cuádruple", 700, vistaAlMar) { }
    }
}
