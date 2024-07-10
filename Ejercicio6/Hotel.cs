using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Hotel
    {
        private List<Habitacion> habitaciones;
        private List<Reserva> reservas;
        private List<Pasajero> pasajeros;

        public Hotel()
        {
            habitaciones = new List<Habitacion>();
            reservas = new List<Reserva>();
            pasajeros = new List<Pasajero>();
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        public void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public bool RegistrarReserva(Habitacion habitacion, DateTime checkIn, DateTime checkOut, bool cuna, List<Pasajero> pasajeros)
        {
            var nuevaReserva = new Reserva(habitacion, checkIn, checkOut, cuna);

            foreach (var reserva in reservas)
            {
                if (nuevaReserva.SeSuperpone(reserva))
                {
                    return false; // No se puede reservar porque hay superposición de fechas
                }
            }

            nuevaReserva.Pasajeros.AddRange(pasajeros);
            reservas.Add(nuevaReserva);
            return true;
        }

        public bool ConfirmarOcupacion(Reserva reserva)
        {
            reserva.Ocupada = true;
            return true;
        }

        public bool CancelarReserva(Reserva reserva, DateTime fechaCancelacion)
        {
            double reintegro = 0;
            if ((reserva.CheckIn - fechaCancelacion).Days < 2)
            {
                reintegro = reserva.Deposito - 0.1 * reserva.CalcularCostoTotal();
            }
            else if ((reserva.CheckIn - fechaCancelacion).Days < 7)
            {
                reintegro = 0.5 * 0.1 * reserva.CalcularCostoTotal() + (reserva.Deposito - 0.1 * reserva.CalcularCostoTotal());
            }
            else
            {
                reintegro = reserva.Deposito;
            }

            reservas.Remove(reserva);
            return true; // Aquí se podría procesar el reintegro en un sistema de pago real
        }

        public double CalcularRecaudacionTotal(DateTime inicio, DateTime fin)
        {
            return reservas.Where(r => r.CheckIn >= inicio && r.CheckOut <= fin)
                           .Sum(r => r.CalcularCostoFinal());
        }

        public Habitacion ObtenerHabitacionMasSolicitada(DateTime inicio, DateTime fin)
        {
            return reservas.Where(r => r.CheckIn >= inicio && r.CheckOut <= fin)
                           .GroupBy(r => r.Habitacion)
                           .OrderByDescending(g => g.Count())
                           .First().Key;
        }

        public Pasajero ObtenerPasajeroFrecuente()
        {
            return reservas.SelectMany(r => r.Pasajeros)
                           .GroupBy(p => p.DNI)
                           .OrderByDescending(g => g.Count())
                           .First().First();
        }

        public Habitacion ObtenerHabitacionMasOcupada()
        {
            return reservas.GroupBy(r => r.Habitacion)
                           .OrderByDescending(g => g.Count())
                           .First().Key;
        }

        public Habitacion ObtenerHabitacionMasOcupada(DateTime inicio, DateTime fin)
        {
            return reservas.Where(r => r.CheckIn >= inicio && r.CheckOut <= fin)
                           .GroupBy(r => r.Habitacion)
                           .OrderByDescending(g => g.Count())
                           .First().Key;
        }
    }
}
