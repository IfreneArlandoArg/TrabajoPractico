using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jardin jardin = new Jardin();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Crear salas
            Sala lactarios = new Sala("Lactarios", 12, 0, 9);
            Sala deambuladores = new Sala("Deambuladores", 15, 9, 18);
            Sala deambuladores2 = new Sala("Deambuladores II", 15, 18, 24);
            Sala sala2 = new Sala("Sala de 2", 18, 24, 36);
            Sala sala3 = new Sala("Sala de 3", 20, 36, 48);

            jardin.AgregarSala(lactarios);
            jardin.AgregarSala(deambuladores);
            jardin.AgregarSala(deambuladores2);
            jardin.AgregarSala(sala2);
            jardin.AgregarSala(sala3);

            // Crear maestras
            Maestra maestra1 = new Maestra("Ana", "Gomez", 1234, 50000, true);
            Maestra maestra2 = new Maestra("Maria", "Perez", 4567, 50000, true);
            Maestra maestra3 = new Maestra("Laura", "Lopez", 8921, 25000, false);
            Maestra maestra4 = new Maestra("Lucia", "Garcia", 1902, 25000, false);
            Maestra maestra5 = new Maestra("Sofia", "Fernandez", 3451, 50000, true);

            // Asignar maestras a salas
            lactarios.Maestras.Add(maestra1);
            lactarios.Maestras.Add(maestra2);

            deambuladores.Maestras.Add(maestra3);
            deambuladores.Maestras.Add(maestra4);

            deambuladores2.Maestras.Add(maestra5);

            sala2.Maestras.Add(maestra1);

            sala3.Maestras.Add(maestra2);


            //Agregar Maestras a lista de Maestras del Jardin sin disticion...
            jardin.AgregarMaestra(maestra1);
            jardin.AgregarMaestra(maestra2);
            jardin.AgregarMaestra(maestra3);
            jardin.AgregarMaestra(maestra4);
            jardin.AgregarMaestra(maestra5);

            // Suscribir al evento de sala sin cupo
            foreach (var sala in jardin.Salas)
            {
                sala.SalaSinCupo += Sala_SalaSinCupo;
            }

            MostrarListBox(lstSalas, jardin.Salas);

            if(jardin.Alumnos.Count > 0)
            MostrarDTGV(dtgvAlumnosJardin, jardin.OrdenarAlumnosPorApellido());

        }

        private void Sala_SalaSinCupo(object sender, EventArgs e)
        {
            MessageBox.Show("La sala no tiene más cupo.", "Cupo completo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void MostrarListBox(ListBox lstB, object pO) 
        {
            lstB.DataSource = null;
            lstB.DataSource = pO;
        }

        void MostrarDTGV(DataGridView dtgv, object pO) 
        { 
           dtgv.DataSource = null;
           dtgv.DataSource = pO;
        }
        void ResetearInputs() 
        { 
           txtNombre.Text = string.Empty;
           txtApellido.Text = string.Empty;
           dateTimePicker1.Value = DateTime.Now;
            chbTieneHermano.Checked = false;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
                    throw new Exception("¡Ingrese correctamente el Nombre y el Apellido!");

                if (lstSalas.SelectedItem is null)
                    throw new Exception("Por favor, seleccione una sala.");

                // Crear un nuevo alumno
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                DateTime fechaNacimiento = dateTimePicker1.Value;
                bool tieneHermano = chbTieneHermano.Checked;

                TipoInscripcion tipo = TipoInscripcion.CuotaBase;

                if(rbCuotaDoble.Checked)
                    tipo = TipoInscripcion.CuotaDoble;
                if (rbCuotaDobleConComedor.Checked)
                    tipo = TipoInscripcion.CuotaDobleConComedor;

                Alumno nuevoAlumno = new Alumno(nombre, apellido, fechaNacimiento, tieneHermano, tipo);

                // Obtener la sala seleccionada
                Sala salaSeleccionada = lstSalas.SelectedItem as Sala;

                // Intentar inscribir al alumno en la sala seleccionada
                if (salaSeleccionada.InscribirAlumno(nuevoAlumno))
                {
                    MessageBox.Show("Alumno inscrito con éxito.", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo inscribir al alumno. La sala está completa.", "Inscripción fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                jardin.Alumnos.Add(nuevoAlumno);

                ResetearInputs();

                MostrarListBox(lstAlumnos, salaSeleccionada.Alumnos);


                MostrarDTGV(dtgvAlumnosJardin, jardin.OrdenarAlumnosPorApellido());


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sala sala = lstSalas.SelectedItem as Sala;
                if(sala.Alumnos.Count == 0)
                    MostrarListBox(lstAlumnos, null);
                if (sala.Alumnos.Count > 0)
                    MostrarListBox(lstAlumnos, sala.Alumnos);
                if (sala.Maestras.Count > 0)
                    MostrarDTGV(dtgvMaestras, sala.Maestras);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!");
                
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Sala sala = lstSalas.SelectedItem as Sala;
                if (lstAlumnos.SelectedItems.Count == 0)
                    throw new Exception($"{sala.Nombre} no tiene alumnos para dar de baja...");

                sala.BajaAlumno(lstAlumnos.SelectedItem as Alumno);

                jardin.Alumnos.Remove(lstAlumnos.SelectedItem as Alumno);

                MostrarListBox(lstAlumnos, sala.Alumnos);
                MostrarDTGV(dtgvAlumnosJardin, jardin.OrdenarAlumnosPorApellido());

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!");
            }
        }

        private void btnRecaudacionMensual_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Recaudación Mensual : {jardin.CalcularRecaudacionMensual()}");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGannaciaMensual_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Ganancia Mensual : {jardin.CalcularGananciaMensual()}");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dtgvAlumnosJardin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
