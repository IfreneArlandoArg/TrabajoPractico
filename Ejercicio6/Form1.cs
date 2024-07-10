using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hotel hotel = new Hotel();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar habitaciones
            hotel.AgregarHabitacion(new HabitacionSimple(101, true));
            hotel.AgregarHabitacion(new HabitacionDobleMatrimonial(102, false));
            hotel.AgregarHabitacion(new HabitacionTriple(103, true));
            hotel.AgregarHabitacion(new HabitacionCuadruple(104, false));

            
        }
        void MostrarResultados() 
        {
            listBox1.Items.Clear();
            // Calcular recaudación
            double recaudacion = hotel.CalcularRecaudacionTotal(DateTime.Now, DateTime.Now.AddMonths(1));
            listBox1.Items.Add("Recaudación Total: " + recaudacion);

            // Obtener habitación más solicitada en un período
            Habitacion habitacionMasSolicitada = hotel.ObtenerHabitacionMasSolicitada(DateTime.Now, DateTime.Now.AddMonths(1));
            listBox1.Items.Add("Habitación más solicitada: " + habitacionMasSolicitada.Numero);

            // Obtener pasajero frecuente
            Pasajero pasajeroFrecuente = hotel.ObtenerPasajeroFrecuente();
            listBox1.Items.Add("Pasajero frecuente: " + pasajeroFrecuente.Nombre + " " + pasajeroFrecuente.Apellido);

            // Obtener habitación más ocupada
            Habitacion habitacionMasOcupada = hotel.ObtenerHabitacionMasOcupada();
            listBox1.Items.Add("Habitación más ocupada: " + habitacionMasOcupada.Numero);

            Habitacion habitacionMasOcupadaPeriodo = hotel.ObtenerHabitacionMasOcupada(DateTime.Now, DateTime.Now.AddMonths(1));
            listBox1.Items.Add("Habitación más ocupada en el período: " + habitacionMasOcupadaPeriodo.Numero);
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Agregar pasajeros
            Pasajero pasajero1 = new Pasajero("Juan", "Perez", new DateTime(1990, 1, 1), "12345678");
            Pasajero pasajero2 = new Pasajero("Maria", "Gomez", new DateTime(1995, 2, 2), "87654321");
            hotel.AgregarPasajero(pasajero1);
            hotel.AgregarPasajero(pasajero2);

            // Registrar reservas
            var reserva1 = new Reserva(new HabitacionSimple(101, true), DateTime.Now.AddDays(1), DateTime.Now.AddDays(5), true);
            hotel.RegistrarReserva(reserva1.Habitacion, reserva1.CheckIn, reserva1.CheckOut, reserva1.Cuna, new List<Pasajero> { pasajero1 });

            var reserva2 = new Reserva(new HabitacionDobleMatrimonial(102, false), DateTime.Now.AddDays(3), DateTime.Now.AddDays(7), false);
            hotel.RegistrarReserva(reserva2.Habitacion, reserva2.CheckIn, reserva2.CheckOut, reserva2.Cuna, new List<Pasajero> { pasajero2 });

            // Confirmar ocupación
            hotel.ConfirmarOcupacion(reserva1);


            MostrarResultados();
        }
    }
}
