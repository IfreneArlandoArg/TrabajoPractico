using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Crear estaciones
            Estacion origen = new Estacion("Retiro", "Buenos Aires", "Buenos Aires");
            Estacion destino = new Estacion("Rosario Norte", "Rosario", "Santa Fe");
            Estacion intermedia1 = new Estacion("San Nicolás", "San Nicolás", "Buenos Aires");
            Estacion intermedia2 = new Estacion("San Pedro", "San Pedro", "Buenos Aires");

            empresa.AgregarEstacion(origen);
            empresa.AgregarEstacion(destino);
            empresa.AgregarEstacion(intermedia1);
            empresa.AgregarEstacion(intermedia2);

            // Crear viaje
            List<Estacion> estacionesIntermedias = new List<Estacion> { intermedia1, intermedia2 };
            Viaje viaje = new Viaje(origen, destino, estacionesIntermedias, 300, 500, 100); // distancia: 300 km, tarifa base: $500, velocidad promedio: 100 km/h

            empresa.AgregarViaje(viaje);

            // Venta de pasaje
            Pasajero pasajero = new Pasajero("Juan", "Pérez", new DateTime(1980, 3, 15), "12345678", false);
            empresa.VenderPasaje(viaje, pasajero, CategoriaVagon.Turista, 20);

            listBox1.Items.Clear();
            // Obtener recaudación total
            listBox1.Items.Add($"Recaudación Total: ${empresa.ObtenerRecaudacionTotal()}");

            // Obtener recaudación por ruta y categoría
            listBox1.Items.Add($"Recaudación Origen: {origen.Nombre} - Destino: {destino.Nombre} - Categoría: Turista: ${empresa.ObtenerRecaudacionPorRutasYCategorias(origen, destino, CategoriaVagon.Turista)}");

            // Obtener cantidad total de pasajeros
            listBox1.Items.Add($"Cantidad Total de Pasajeros: {empresa.ObtenerCantidadTotalPasajeros()}");

            // Obtener cantidad de pasajeros por ruta y categoría
            listBox1.Items.Add($"Cantidad Pasajeros Origen: {origen.Nombre} - Destino: {destino.Nombre} - Categoría: Turista: {empresa.ObtenerCantidadPasajerosPorRutasYCategorias(origen, destino, CategoriaVagon.Turista)}");

            // Verificar disponibilidad de lugares
            listBox1.Items.Add($"Hay Lugares Disponibles: {empresa.HayLugaresDisponibles(viaje, CategoriaVagon.Turista)}");
        

    }
    }
}
