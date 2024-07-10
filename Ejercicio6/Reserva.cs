using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Reserva
    {
        public Habitacion Habitacion { get; set; }
        public List<Pasajero> Pasajeros { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Cuna { get; set; }
        public double Deposito { get; set; }
        public double ConsumoFrigobar { get; set; }
        public double OtrosConsumos { get; set; }
        public bool Ocupada { get; set; }

        public Reserva(Habitacion habitacion, DateTime checkIn, DateTime checkOut, bool cuna)
        {
            Habitacion = habitacion;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Cuna = cuna;
            Pasajeros = new List<Pasajero>();
            Ocupada = false;
            Deposito = 0;
            ConsumoFrigobar = 0;
            OtrosConsumos = 0;
        }

        public double CalcularCostoTotal()
        {
            int noches = (CheckOut - CheckIn).Days;
            return Habitacion.CalcularCostoTotal(noches, Cuna);
        }

        public double CalcularCostoFinal()
        {
            return CalcularCostoTotal() + ConsumoFrigobar + OtrosConsumos;
        }

        public double CalcularGanancia()
        {
            return CalcularCostoFinal() - Deposito;
        }

        public void RegistrarDeposito(double monto)
        {
            Deposito = monto;
        }

        public bool SeSuperpone(Reserva otra)
        {
            return CheckIn < otra.CheckOut && CheckOut > otra.CheckIn;
        }
    }
}
