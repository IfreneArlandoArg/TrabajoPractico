using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Biblioteca biblioteca = new Biblioteca();

        List<Ejemplar> listTemp = new List<Ejemplar>();

        void MostrarLstBox(ListBox lsB, object pO)
        { 
            lsB.DataSource = null;
            lsB.DataSource = pO;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                //Cargamento Libros
                biblioteca.AgregarLibro(new Libro("Cien Años de Soledad", new Autor("Gabriel", "García Márquez", new DateTime(1927, 3, 6)), 1967, "Editorial Sudamericana", "Primera"));
                biblioteca.AgregarLibro(new Libro("1984", new Autor("George", "Orwell", new DateTime(1903, 6, 25)), 1949, "Secker & Warburg", "Primera"));
                biblioteca.AgregarLibro(new Libro("El Principito", new Autor("Antoine", "de Saint-Exupéry", new DateTime(1900, 6, 29)), 1943, "Reynal & Hitchcock", "Primera"));
                biblioteca.AgregarLibro(new Libro("Don Quijote de la Mancha", new Autor("Miguel", "de Cervantes", new DateTime(1547, 9, 29)), 1605, "Francisco de Robles", "Primera"));
                biblioteca.AgregarLibro(new Libro("Matar a un ruiseñor", new Autor("Harper", "Lee", new DateTime(1926, 4, 28)), 1960, "J.B. Lippincott & Co.", "Primera"));

                //Cargamento LibrosConMaterialDigital
                biblioteca.AgregarLibroConMaterialDigital(new LibroConMaterialDigital("Cien Años de Soledad", new Autor("Gabriel", "García Márquez", new DateTime(1927, 3, 6)), 1967, "Editorial Sudamericana", "Primera", 1));
                biblioteca.AgregarLibroConMaterialDigital(new LibroConMaterialDigital("1984", new Autor("George", "Orwell", new DateTime(1903, 6, 25)), 1949, "Secker & Warburg", "Primera", 2));
                biblioteca.AgregarLibroConMaterialDigital(new LibroConMaterialDigital("El Principito", new Autor("Antoine", "de Saint-Exupéry", new DateTime(1900, 6, 29)), 1943, "Reynal & Hitchcock", "Primera", 1));
                biblioteca.AgregarLibroConMaterialDigital(new LibroConMaterialDigital("Don Quijote de la Mancha", new Autor("Miguel", "de Cervantes", new DateTime(1547, 9, 29)), 1605, "Francisco de Robles", "Primera", 3));
                biblioteca.AgregarLibroConMaterialDigital(new LibroConMaterialDigital("Matar a un ruiseñor", new Autor("Harper", "Lee", new DateTime(1926, 4, 28)), 1960, "J.B. Lippincott & Co.", "Primera", 1));

                //Cargamento Revistas...
                biblioteca.AgregarRevista(new Revista("National Geographic", new Autor("John", "Doe", new DateTime(1970, 1, 1)), 2021, "National Geographic Partners", "Vol. 1", "Exploración y Ciencia", 101, TipoEntrega.Mensual));
                biblioteca.AgregarRevista(new Revista("Scientific American", new Autor("Jane", "Smith", new DateTime(1975, 2, 1)), 2021, "Springer Nature", "Vol. 2", "Ciencia y Tecnología", 205, TipoEntrega.Mensual));
                biblioteca.AgregarRevista(new Revista("TIME", new Autor("Alice", "Johnson", new DateTime(1980, 3, 1)), 2021, "Time USA, LLC", "Vol. 3", "Noticias y Cultura", 120, TipoEntrega.Diario));
                biblioteca.AgregarRevista(new Revista("Forbes", new Autor("Bob", "Brown", new DateTime(1985, 4, 1)), 2021, "Forbes Media", "Vol. 4", "Negocios y Finanzas", 200, TipoEntrega.Mensual));
                biblioteca.AgregarRevista(new Revista("The New Yorker", new Autor("Charlie", "Wilson", new DateTime(1990, 5, 1)), 2021, "Condé Nast", "Vol. 5", "Cultura y Arte", 300, TipoEntrega.Quincenal));

                if (rbLibro.Checked && biblioteca.ObtenerLibros().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerLibros());
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"¡Error Cargamento Data!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void rbLibro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbLibro.Checked && biblioteca.ObtenerLibros().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerLibros());
                }
                if (rbLibroMaterialDigital.Checked && biblioteca.ObtenerLibrosConMaterialDigital().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerLibrosConMaterialDigital());
                }
                if (rbRevista.Checked && biblioteca.ObtenerRevistas().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerRevistas());
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbEjemplares.SelectedItems.Count == 0)
                    throw new Exception("Tiene qué seleccionar un ejemplar...");

                if (biblioteca.ObtenerClientesRegistrados().Count == 0)
                    throw new Exception("Primero Registré, y/o seleccioné un cliente...");

                
                Cliente cli = lsbCliente.SelectedItem as Cliente;


                if (cli.PrimeraVez && listTemp.Count == 1)
                {
                    MessageBox.Show($"Por ser la primera vez, {cli.Apellido} sólo puede prestar un ejemplar\nProcede a completar el Prestamo.");
                }
                else
                {
                    if(listTemp.Count < 3) 
                    { 
                        Ejemplar ej = lsbEjemplares.SelectedItem as Ejemplar;

                        listTemp.Add(ej);

                        MostrarLstBox(lsbEjemplaresCliente, listTemp);
                    }
                }
                

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompletarPrestano_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbEjemplares.SelectedItems.Count == 0)
                    throw new Exception("Tiene qué seleccionar un ejemplar...");

                if (biblioteca.ObtenerClientesRegistrados().Count == 0)
                    throw new Exception("Primero Registré, y/o seleccioné un cliente...");


                Cliente cli = lsbCliente.SelectedItem as Cliente;

                Prestamo pPrestamo = new Prestamo(cli, listTemp);

                biblioteca.Prestar(listTemp);

                listTemp = new List<Ejemplar>();

                MostrarLstBox(lsbEjemplaresCliente, listTemp);

                biblioteca.AgregarPrestamo(pPrestamo);

               

                MostrarLstBox(lstPrestamos, biblioteca.ObtenerPrestamos());

                MostrarLstBox(lsbEjemplaresCliente,null);

                
                if (rbLibro.Checked && biblioteca.ObtenerLibros().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerLibros());
                }
                if (rbLibroMaterialDigital.Checked && biblioteca.ObtenerLibrosConMaterialDigital().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerLibrosConMaterialDigital());
                }
                if (rbRevista.Checked && biblioteca.ObtenerRevistas().Count > 0)
                {
                    MostrarLstBox(lsbEjemplares, biblioteca.ObtenerRevistas());
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(txtNombre.Text,txtApellido.Text, dtpkFechaNacimiento.Value, chBoxPrimeraVez.Checked);

                biblioteca.AgregarClienteRegistrado(cliente);

                MostrarLstBox(lsbCliente, biblioteca.ObtenerClientesRegistrados());

                txtApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                dtpkFechaNacimiento.Value = DateTime.Now;
                chBoxPrimeraVez.Checked = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
