using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Museo museo = new Museo();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void MostrarResultados() 
        {
            listBox1.Items.Clear();

            // Calcular recaudación total
            listBox1.Items.Add($"Recaudación Total: {museo.CalcularRecaudacionTotal()}");

            // Obtener atracción más visitada
            listBox1.Items.Add($"Atracción Más Visitada: {museo.ObtenerAtraccionMasVisitada().Nombre}");

            // Obtener atracción con mayor recaudación
            listBox1.Items.Add($"Atracción Mayor Recaudación: {museo.ObtenerAtraccionMayorRecaudacion().Nombre}");

            // Buscar un animal por nombre
            var busqueda = museo.BuscarAnimalPorNombre("Águila");
            foreach (var animal in busqueda)
            {
                listBox1.Items.Add($"Animale(s) encontrados con Nombre \"Águila\" {animal.Nombre}");
            }

            // Buscar animales por periodo
            var animalesPeriodo = museo.BuscarAnimalesPorPeriodo(1000000, 65000000);
            foreach (var animal in animalesPeriodo)
            {
                listBox1.Items.Add($"Animal encontrado entre 1000000, 65000000 : {animal.Nombre}");
            }

            // Buscar animales por periodo y sector
            var animalesPeriodoSector = museo.BuscarAnimalesPorPeriodoYSector(1000000, 65000000, "Sector de animales terrestres");
            foreach (var animal in animalesPeriodoSector)
            {
                listBox1.Items.Add($"Animale por 1000000 - 65000000 \"Sector de animales terrestres\" : {animal.Nombre}");
            }

        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Agregar atracciones
            var acuaticos = new Atraccion("Sector de animales acuáticos", 50);
            var terrestres = new Atraccion("Sector de animales terrestres", 50);
            var aereos = new Atraccion("Sector de animales de aire", 50);

            museo.AgregarAtraccion(acuaticos);
            museo.AgregarAtraccion(terrestres);
            museo.AgregarAtraccion(aereos);

            // Agregar animales
            var animal1 = new AnimalAcuatico("Tiburón", "Océano", "Carnívoro", 1000000);
            var animal2 = new AnimalTerrestre("Tiranosaurio", "Bosques", "Carnívoro", 65000000, true, false, false);
            var animal3 = new AnimalAereo("Águila", "Montañas", "Carnívoro", 2000000, 8, 120);

            acuaticos.AgregarAnimal(animal1);
            terrestres.AgregarAnimal(animal2);
            aereos.AgregarAnimal(animal3);
            // Agregar pasaportes
            var pasaporte1 = new Pasaporte("Juan", "Pérez", new DateTime(1955, 5, 12));
            pasaporte1.AgregarAtraccion(acuaticos);
            pasaporte1.AgregarAtraccion(terrestres);

            var pasaporte2 = new Pasaporte("Ana", "Gómez", new DateTime(2015, 8, 30));
            pasaporte2.AgregarAtraccion(aereos);

            museo.RegistrarPasaporte(pasaporte1);
            museo.RegistrarPasaporte(pasaporte2);

            MostrarResultados();

        }
    }
}
