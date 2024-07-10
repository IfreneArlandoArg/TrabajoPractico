using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Pasaje
    {
        public Viaje Viaje { get; set; }
        public Pasajero Pasajero { get; set; }
        public CategoriaVagon Categoria { get; set; }
        public int NumeroButaca { get; set; }
        public double CostoTotal { get; set; }

        public Pasaje(Viaje viaje, Pasajero pasajero, CategoriaVagon categoria, int numeroButaca, double costoTotal)
        {
            Viaje = viaje;
            Pasajero = pasajero;
            Categoria = categoria;
            NumeroButaca = numeroButaca;
            CostoTotal = costoTotal;
        }

        public override string ToString()
        {
            return $"Pasaje: {Pasajero.Nombre} {Pasajero.Apellido}\n" +
                   $"   Viaje: {Viaje}\n" +
                   $"   Categoría: {Categoria}, Butaca: {NumeroButaca}\n" +
                   $"   Costo Total: ${CostoTotal}";
        }
    }
}
