using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SistemaHospital sistema = new SistemaHospital();

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        void MostrarLstBox(ListBox lstb, object pO) 
        {
            lstb.DataSource = null;
            lstb.DataSource = pO;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear especialidades
                Especialidad cardiologia = new Especialidad("Cardiología");
                Especialidad neurologia = new Especialidad("Neurología");
                Especialidad pediatria = new Especialidad("Pediatría");
                Especialidad dermatologia = new Especialidad("Dermatología");
                Especialidad psiquiatria = new Especialidad("Psiquiatría");
                Especialidad endocrinologia = new Especialidad("Endocrinología");

                sistema.AgregarEspecialidad(cardiologia);
                sistema.AgregarEspecialidad(neurologia);
                sistema.AgregarEspecialidad(pediatria);
                sistema.AgregarEspecialidad(dermatologia);
                sistema.AgregarEspecialidad(psiquiatria);
                sistema.AgregarEspecialidad(endocrinologia);

                // Crear estudios
                Estudio ecocardiograma = new Estudio("Ecocardiograma", 1000, 5);
                Estudio electroencefalograma = new Estudio("Electroencefalograma", 1500, 3);
                Estudio hemograma = new Estudio("Hemograma", 500, 10);
                Estudio radiografia = new Estudio("Radiografía", 800, 7);
                Estudio resonancia = new Estudio("Resonancia Magnética", 2000, 4);
                Estudio ecografia = new Estudio("Ecografía", 900, 6);

                cardiologia.AgregarEstudio(ecocardiograma);
                neurologia.AgregarEstudio(electroencefalograma);
                pediatria.AgregarEstudio(hemograma);
                dermatologia.AgregarEstudio(radiografia);
                psiquiatria.AgregarEstudio(resonancia);
                endocrinologia.AgregarEstudio(ecografia);

                // Crear médicos
                Medico drPerez = new Medico("Dr. Pérez", 2000);
                drPerez.Especialidades.Add(cardiologia);
                sistema.AgregarMedico(drPerez);

                Medico drGomez = new Medico("Dr. Gómez", 2500);
                drGomez.Especialidades.Add(neurologia);
                sistema.AgregarMedico(drGomez);

                Medico drLopez = new Medico("Dr. López", 1800);
                drLopez.Especialidades.Add(pediatria);
                sistema.AgregarMedico(drLopez);

                Medico drMartinez = new Medico("Dr. Martínez", 2200);
                drMartinez.Especialidades.Add(dermatologia);
                sistema.AgregarMedico(drMartinez);

                Medico drDiaz = new Medico("Dr. Díaz", 2600);
                drDiaz.Especialidades.Add(psiquiatria);
                sistema.AgregarMedico(drDiaz);

                Medico drFernandez = new Medico("Dr. Fernández", 2100);
                drFernandez.Especialidades.Add(endocrinologia);
                sistema.AgregarMedico(drFernandez);

                // Crear pacientes y sus historias clínicas
                List<HistoriaClinica> historiasJuan = new List<HistoriaClinica>();
                for (int i = 0; i < 6; i++)
                {
                    var especialidad = i % 2 == 0 ? cardiologia : neurologia;
                    var estudio = i % 2 == 0 ? ecocardiograma : electroencefalograma;
                    var medico = i % 2 == 0 ? drPerez : drGomez;

                    HistoriaClinica historia = new HistoriaClinica(DateTime.Now.AddMonths(-i), especialidad);
                    OrdenMedica orden = new OrdenMedica { Medico = medico, Estudio = estudio, Fecha = DateTime.Now.AddMonths(-i) };
                    historia.AgregarOrdenMedica(orden);
                    historia.RegistrarResultado($"{estudio.Nombre} normal.");
                    historiasJuan.Add(historia);
                }

                Paciente juan = new Paciente("Juan Pérez", "12345678", new DateTime(1980, 5, 20), historiasJuan);
                sistema.AgregarPaciente(juan);

                List<HistoriaClinica> historiasMaria = new List<HistoriaClinica>();
                for (int i = 0; i < 6; i++)
                {
                    var especialidad = i % 2 == 0 ? pediatria : dermatologia;
                    var estudio = i % 2 == 0 ? hemograma : radiografia;
                    var medico = i % 2 == 0 ? drLopez : drMartinez;

                    HistoriaClinica historia = new HistoriaClinica(DateTime.Now.AddMonths(-i), especialidad);
                    OrdenMedica orden = new OrdenMedica { Medico = medico, Estudio = estudio, Fecha = DateTime.Now.AddMonths(-i) };
                    historia.AgregarOrdenMedica(orden);
                    historia.RegistrarResultado($"{estudio.Nombre} normal.");
                    historiasMaria.Add(historia);
                }

                Paciente maria = new Paciente("Maria Garcia", "87654321", new DateTime(1990, 10, 15), historiasMaria);
                sistema.AgregarPaciente(maria);


                foreach( var item in sistema.Especialidades) 
                { 
                    cmbEspecialidad.Items.Add(item.Nombre);
                }

                cmbEspecialidad.SelectedIndex = 0;


                MostrarLstBox(lstbEspecialidades, sistema.Especialidades);
                MostrarLstBox(lstbMedicos, sistema.Medicos);
                MostrarLstBox(lstbPacientes, sistema.Pacientes);

                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Medico tempMedico = lstbMedicos.SelectedItem as Medico;
                if (tempMedico != null && tempMedico.Especialidades != null)
                {
                    if (tempMedico.Especialidades.Count == 0)
                    {
                        lstbEspecialidades.Items.Clear();
                    }
                    else
                    {
                        MostrarLstBox(lstbEspecialidades, tempMedico.Especialidades);
                    }
                }
                else
                {
                    
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void lstbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el paciente seleccionado del ListBox
                Paciente tempPaciente = lstbPacientes.SelectedItem as Paciente;

                
                if (tempPaciente != null)
                {

                    var historiasPorFechaDescendiente = tempPaciente.ObtenerHistoriasOrdenadasPorFecha();
                    MostrarLstBox(lstHistorFechaDescendiente, historiasPorFechaDescendiente);

                    MostrarLstBox(lstbFiltradaEspecialidad, tempPaciente.FiltrarHistoriasPorEspecialidad());

                    
                    if (tempPaciente.HistoriasClinicas.Count == 0)
                    {
                        
                        MostrarLstBox(lstbPacientes, null); 
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnCargarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos de los TextBox y ComboBox
                string nombreMedico = txtNombreMedico.Text;
                if (string.IsNullOrEmpty(nombreMedico))
                {
                    throw new Exception("Por favor, ingrese el nombre del médico.");
                    
                }

                if (!decimal.TryParse(txtCostoBaseMedico.Text, out decimal costoBaseMedico))
                {
                    throw new Exception("Por favor, ingrese un costo base válido.");
                    
                }

                if (cmbEspecialidad.SelectedItem == null)
                {
                    throw new Exception("Por favor, seleccione una especialidad.");
                    
                }

                string nombreEspecialidad = cmbEspecialidad.SelectedItem.ToString();

                // Crear el médico
                Medico nuevoMedico = new Medico(nombreMedico, costoBaseMedico);

                // Buscar la especialidad seleccionada y agregarla al médico
                Especialidad especialidadSeleccionada = sistema.Especialidades.Where(x => x.Nombre == nombreEspecialidad).First();

                nuevoMedico.Especialidades.Add(especialidadSeleccionada); ;

                // Agregar el médico al sistema
                sistema.AgregarMedico(nuevoMedico);

                // Actualizar ListBox de médicos
                MostrarLstBox(lstbMedicos, sistema.Medicos);

                // Limpiar los TextBox y ComboBox
                txtNombreMedico.Clear();
                txtCostoBaseMedico.Clear();
                cmbEspecialidad.SelectedIndex = 0;

                MessageBox.Show("Médico agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGananciaTotal_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Ganancia total : {sistema.CalcularGananciaTotal()}");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nombre = txtNombrePaciente.Text;
                string dni = txtDniPaciente.Text;
                DateTime fechaNacimiento = dateTimePicker1.Value;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("Por favor, ingrese el nombre del paciente.");
                    
                }

                if (string.IsNullOrEmpty(dni))
                {
                    throw new Exception("Por favor, ingrese el DNI del paciente.");
                    
                }

                List<HistoriaClinica> temp = new List<HistoriaClinica>();
                
                

                // Crear historias clínicas y agregarlas al paciente
                for (int i = 0; i < 6; i++)
                {
                    // Simulación de creación de historias clínicas con especialidades alternadas
                    Especialidad especialidad = i % 2 == 0 ? sistema.Especialidades.FirstOrDefault(x => x.Nombre == "Cardiología") : sistema.Especialidades.FirstOrDefault(y => y.Nombre == "Neurología");
                    Estudio estudio = i % 2 == 0 ? new Estudio("Ecocardiograma", 1000, 5) : new Estudio("Electroencefalograma", 1500, 3);
                    Medico medico = i % 2 == 0 ? sistema.Medicos.FirstOrDefault(m => m.Nombre == "Dr. Pérez") : sistema.Medicos.FirstOrDefault(m => m.Nombre == "Dr. Gómez");

                    // Crear historia clínica
                    HistoriaClinica historia = new HistoriaClinica(DateTime.Now.AddDays(-i), especialidad);
                    OrdenMedica orden = new OrdenMedica { Medico = medico, Estudio = estudio, Fecha = DateTime.Now.AddDays(-i) };
                    historia.AgregarOrdenMedica(orden);
                    historia.RegistrarResultado($"Resultado del estudio {estudio.Nombre}");

                    // Agregar historia clínica al paciente

                    temp.Add(historia);
                }

                Paciente nuevoPaciente = new Paciente(nombre, dni, fechaNacimiento, temp);

                // Agregar paciente al sistema
                sistema.AgregarPaciente(nuevoPaciente);

                // Actualizar ListBox de Pacientes
                MostrarLstBox(lstbPacientes, sistema.Pacientes);

                // Limpiar los controles después de la carga
                LimpiarControlesPaciente();

                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LimpiarControlesPaciente()
        {
            txtNombrePaciente.Text = string.Empty;
            txtDniPaciente.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
