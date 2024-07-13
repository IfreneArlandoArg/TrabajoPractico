using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EmpresaFerroviaria empresa = new EmpresaFerroviaria();

        void MostrarViajesDisponibles(ListBox lsb, object pO) 
        {
            lsb.DataSource = null;
            lsb.DataSource = pO;
        
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {

                Viaje viaje = lstBViajes.SelectedItem as Viaje;

                var categoriaWagon = CategoriaVagon.Turista;

                if (rbPullman.Checked)
                    categoriaWagon = CategoriaVagon.Pullman;
                if (rbEjecutivo.Checked)
                    categoriaWagon = CategoriaVagon.Ejecutivo;

                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                DateTime FechaNacimiento = dtpckFechaNacimiento.Value;
               // int NumeroButaca;

                Regex rgxDNI = new Regex(@"^[0-9]{8}$");
                if (!rgxDNI.IsMatch(txtDNI.Text))
                    throw new Exception("El DNI tiene qué ser un valor numerico de 8 números.");

                string DNI = txtDNI.Text;

                bool NecesitaAutorizacionPadres = (DateTime.Today.Year - FechaNacimiento.Year) < 18;

                // Venta de pasaje
                Pasajero pasajero = new Pasajero(Nombre, Apellido, FechaNacimiento, DNI, NecesitaAutorizacionPadres);
                empresa.VenderPasaje(viaje, pasajero, categoriaWagon, 20);

                listBox1.Items.Clear();
                // Obtener recaudación total
                listBox1.Items.Add($"Recaudación Total: ${empresa.ObtenerRecaudacionTotal()}");

                // Obtener recaudación por ruta y categoría
                listBox1.Items.Add($"Recaudación Origen: {viaje.Origen.Nombre} - Destino: {viaje.Destino.Nombre} - Categoría: Turista: ${empresa.ObtenerRecaudacionPorRutasYCategorias(viaje.Origen, viaje.Destino, categoriaWagon)}");

                // Obtener cantidad total de pasajeros
                listBox1.Items.Add($"Cantidad Total de Pasajeros: {empresa.ObtenerCantidadTotalPasajeros()}");

                // Obtener cantidad de pasajeros por ruta y categoría
                listBox1.Items.Add($"Cantidad Pasajeros Origen: {viaje.Origen.Nombre} - Destino: {viaje.Destino.Nombre} - Categoría: Turista: {empresa.ObtenerCantidadPasajerosPorRutasYCategorias(viaje.Origen, viaje.Destino, categoriaWagon)}");

                // Verificar disponibilidad de lugares
                listBox1.Items.Add($"Hay Lugares Disponibles: {empresa.HayLugaresDisponibles(viaje, categoriaWagon)}");
            }


            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear estaciones
                Estacion origen1 = new Estacion("Retiro", "Buenos Aires", "Buenos Aires");
                Estacion destino1 = new Estacion("Rosario Norte", "Rosario", "Santa Fe");
                Estacion intermedia11 = new Estacion("San Nicolás", "San Nicolás", "Buenos Aires");
                Estacion intermedia12 = new Estacion("San Pedro", "San Pedro", "Buenos Aires");

                // Agregar estaciones a la empresa
                empresa.AgregarEstacion(origen1);
                empresa.AgregarEstacion(destino1);
                empresa.AgregarEstacion(intermedia11);
                empresa.AgregarEstacion(intermedia12);

                // Crear y agregar el primer viaje
                List<Estacion> estacionesIntermedias1 = new List<Estacion> { intermedia11, intermedia12 };
                Viaje viaje1 = new Viaje(origen1, destino1, estacionesIntermedias1, 300, 500, 100); // distancia: 300 km, tarifa base: $500, velocidad promedio: 100 km/h
                empresa.AgregarViaje(viaje1);

                // Crear estaciones para el segundo viaje
                Estacion origen2 = new Estacion("Constitución", "Buenos Aires", "Buenos Aires");
                Estacion destino2 = new Estacion("Córdoba", "Córdoba", "Córdoba");
                Estacion intermedia21 = new Estacion("Junín", "Junín", "Buenos Aires");
                Estacion intermedia22 = new Estacion("Villa María", "Villa María", "Córdoba");

                // Agregar estaciones a la empresa
                empresa.AgregarEstacion(origen2);
                empresa.AgregarEstacion(destino2);
                empresa.AgregarEstacion(intermedia21);
                empresa.AgregarEstacion(intermedia22);

                // Crear y agregar el segundo viaje
                List<Estacion> estacionesIntermedias2 = new List<Estacion> { intermedia21, intermedia22 };
                Viaje viaje2 = new Viaje(origen2, destino2, estacionesIntermedias2, 400, 600, 120); // distancia: 400 km, tarifa base: $600, velocidad promedio: 120 km/h
                empresa.AgregarViaje(viaje2);

                // Crear estaciones para el tercer viaje
                Estacion origen3 = new Estacion("Once", "Buenos Aires", "Buenos Aires");
                Estacion destino3 = new Estacion("Mar del Plata", "Mar del Plata", "Buenos Aires");
                Estacion intermedia31 = new Estacion("Chascomús", "Chascomús", "Buenos Aires");
                Estacion intermedia32 = new Estacion("Dolores", "Dolores", "Buenos Aires");

                // Agregar estaciones a la empresa
                empresa.AgregarEstacion(origen3);
                empresa.AgregarEstacion(destino3);
                empresa.AgregarEstacion(intermedia31);
                empresa.AgregarEstacion(intermedia32);

                // Crear y agregar el tercer viaje
                List<Estacion> estacionesIntermedias3 = new List<Estacion> { intermedia31, intermedia32 };
                Viaje viaje3 = new Viaje(origen3, destino3, estacionesIntermedias3, 350, 550, 110); // distancia: 350 km, tarifa base: $550, velocidad promedio: 110 km/h
                empresa.AgregarViaje(viaje3);

                // Crear estaciones para el cuarto viaje
                Estacion origen4 = new Estacion("Tucumán", "San Miguel de Tucumán", "Tucumán");
                Estacion destino4 = new Estacion("Salta", "Salta", "Salta");
                Estacion intermedia41 = new Estacion("Jujuy", "San Salvador de Jujuy", "Jujuy");
                Estacion intermedia42 = new Estacion("Tafí del Valle", "Tafí del Valle", "Tucumán");

                // Agregar estaciones a la empresa
                empresa.AgregarEstacion(origen4);
                empresa.AgregarEstacion(destino4);
                empresa.AgregarEstacion(intermedia41);
                empresa.AgregarEstacion(intermedia42);

                // Crear y agregar el cuarto viaje
                List<Estacion> estacionesIntermedias4 = new List<Estacion> { intermedia41, intermedia42 };
                Viaje viaje4 = new Viaje(origen4, destino4, estacionesIntermedias4, 500, 700, 130); // distancia: 500 km, tarifa base: $700, velocidad promedio: 130 km/h
                empresa.AgregarViaje(viaje4);

                // Crear estaciones para el quinto viaje
                Estacion origen5 = new Estacion("Bahía Blanca", "Bahía Blanca", "Buenos Aires");
                Estacion destino5 = new Estacion("Neuquén", "Neuquén", "Neuquén");
                Estacion intermedia51 = new Estacion("Viedma", "Viedma", "Río Negro");
                Estacion intermedia52 = new Estacion("General Roca", "General Roca", "Río Negro");

                // Agregar estaciones a la empresa
                empresa.AgregarEstacion(origen5);
                empresa.AgregarEstacion(destino5);
                empresa.AgregarEstacion(intermedia51);
                empresa.AgregarEstacion(intermedia52);

                // Crear y agregar el quinto viaje
                List<Estacion> estacionesIntermedias5 = new List<Estacion> { intermedia51, intermedia52 };
                Viaje viaje5 = new Viaje(origen5, destino5, estacionesIntermedias5, 450, 600, 115); // distancia: 450 km, tarifa base: $600, velocidad promedio: 115 km/h
                empresa.AgregarViaje(viaje5);


                MostrarViajesDisponibles(lstBViajes, empresa.ObtenerLstViajes());


                int i = 20;

                while (i > 0) 
                { 
                  comboBox1.Items.Add(i);
                    i--;
                }

                comboBox1.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
