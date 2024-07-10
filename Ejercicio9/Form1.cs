using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CuerpoCeleste> lstCuerpoCelestes = new List<CuerpoCeleste>();
        // Crear observador
        Persona observador = new Persona("Juan", "Pérez", new DateTime(1985, 10, 15), "001");
        Constelacion constelacion1 = new Constelacion("Orion");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crear una estrella
            Estrella estrella1 = new Estrella(DateTime.Today, observador, 10.5, "Sol",
                                              2.5, 5500, 300, 3.8, ColorEstrella.Amarilla, TipoEstrella.Enana);

            // Crear un planeta en sistema planetario simple
            Planeta planeta1 = new Planeta(DateTime.Today, observador, 12.3, "Tierra",
                                           0.8, 150, -50);
            planeta1.EstrellaOrbita = estrella1;
            planeta1.DistanciaEstrella = 4.4;
            planeta1.EsZonaRicitosDeOro = true;
            planeta1.EsPotencialmenteHabitable = true;

            // Crear un satélite
            Satelite satelite1 = new Satelite(DateTime.Today, observador, 0.1, "Luna",
                                              true, 0.02, 100);
            planeta1.Satelites.Add(satelite1);

           
            
            constelacion1.AgregarEstrella(estrella1);

            lstCuerpoCelestes.Add(estrella1);
            lstCuerpoCelestes.Add(planeta1);
            lstCuerpoCelestes.Add(satelite1);


            mostrarLsBox(listBox1, lstCuerpoCelestes);
        }

        void mostrarLsBox(ListBox lsB, Object pO) 
        {
            lsB.DataSource = null;
            lsB.DataSource = pO;
        }

        void limpiarTxtBox() 
        {
            txtDistanciaAnLuz.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtMasa.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDistanciaAnLuz.Text == string.Empty || txtEdad.Text == string.Empty || txtMasa.Text == string.Empty || txtNombre.Text == string.Empty) 
                {
                    throw new Exception("Todos los text boxes tienen qué tener los datos necesarios para agregar nuevo cuerpo celeste...");
                }

                double distanciaAñoL;
                double edad;
                double masa;

                bool boolDist = double.TryParse(txtDistanciaAnLuz.Text, out distanciaAñoL);

                if (!boolDist)
                    throw new Exception("La distancia tiene qué ser un valor numerico.");

                bool boolEdad = double.TryParse(txtEdad.Text, out edad);

                if (!boolEdad)
                    throw new Exception("La Edad tiene qué ser un valor numerico.");

                bool boolMasa = double.TryParse(txtMasa.Text, out masa);

                if (!boolMasa)
                    throw new Exception("La Masa tiene qué ser un valor numerico.");


                CuerpoCeleste cuerpoCeleste = null;

                if(rbEstrella.Checked)
                    cuerpoCeleste = new Estrella(DateTime.Today, observador, distanciaAñoL, txtNombre.Text,
                                              masa, 5500, edad, 3.8, ColorEstrella.Amarilla, TipoEstrella.Enana);
                if (rbPlaneta.Checked) {
                    cuerpoCeleste = new Planeta(DateTime.Today, observador, distanciaAñoL, txtNombre.Text,
                                               masa, edad, -50)
                    { DistanciaEstrella = 4.4, EsZonaRicitosDeOro = true, EsPotencialmenteHabitable = true };
                    //planeta1.EstrellaOrbita = estrella1;
                    
                   
                }

                if(rbSatelite.Checked)
                    cuerpoCeleste = new Satelite(DateTime.Today, observador, distanciaAñoL, txtNombre.Text,
                                              true, masa, edad);


                lstCuerpoCelestes.Add(cuerpoCeleste);

                limpiarTxtBox();

                mostrarLsBox(listBox1, lstCuerpoCelestes);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CuerpoCeleste tempCuCel = listBox1.SelectedItem as CuerpoCeleste;


                if(!(txtNombre.Text == string.Empty))
                    tempCuCel.Nombre = txtNombre.Text;

                double distanciaAñoL;
                
                bool boolDist = double.TryParse(txtDistanciaAnLuz.Text, out distanciaAñoL);




                if (!(txtDistanciaAnLuz.Text == string.Empty) )
                { 
                    tempCuCel.DistanciaAniosLuz = distanciaAñoL;
                    if (!boolDist)
                        throw new Exception("La distancia tiene qué ser un valor numerico.");
                }

                limpiarTxtBox();

                mostrarLsBox(listBox1, lstCuerpoCelestes);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}
