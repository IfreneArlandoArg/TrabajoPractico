using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Polideportivo polideportivo = new Polideportivo();

        Juez juez1 = new Juez("Juan", "Perez", "J001");
        Juez juez2 = new Juez("Carlos", "Gomez", "J002");
        Juez juez3 = new Juez("Luis", "Rodriguez", "J003");

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int x = 9;

                while (x <= 23)
                {
                    if (x < 10)
                    {
                        comboBox1.Items.Add($"0{x}:00");
                    }
                    else
                    {
                        comboBox1.Items.Add($"{x}:00");
                    }


                    x++;
                }
                comboBox1.SelectedItem = comboBox1.Items[0];

                
                polideportivo.AgregarJuez(juez1);
                polideportivo.AgregarJuez(juez2);
                polideportivo.AgregarJuez(juez3);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void mostrarResultados() 
        {
            lsbVentasInfos.Items.Clear();

            lsbVentasInfos.Items.Add("Recaudación total: " + polideportivo.CalcularRecaudacionTotal());
            lsbVentasInfos.Items.Add("Ganancia total: " + polideportivo.CalcularGananciaTotal());
            lsbVentasInfos.Items.Add("Cancha más alquilada: " + polideportivo.ObtenerCanchaMasAlquilada().Nombre);
            lsbVentasInfos.Items.Add("Cancha que más recaudó: " + polideportivo.ObtenerCanchaMasRecaudo().Nombre);
            lsbVentasInfos.Items.Add("Juez con más partidos dirigidos: " + polideportivo.ObtenerJuezMasPartidosDirigidos().Nombre);
            lsbVentasInfos.Items.Add("Juez con mayor ganancia: " + polideportivo.ObtenerJuezMayorGanancia().Nombre);
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                Cancha cancha = null;

                List<Juez> lstJuezTemp = new List<Juez>();
                
                if(rbCanchaTenis.Checked)
                {
                    cancha = new CanchaTenis() 
                    {
                        ConArbitro = rb1Arbitro.Checked
                    };

                    if(rb1Arbitro.Checked)
                    lstJuezTemp.Add(juez1);



                }
                if(rbCanchaFutbol5.Checked)
                {
                    cancha = new CanchaFutbol5();
                }
                if (rbCanchaFutbol7.Checked) 
                {
                    cancha = new CanchaFutbol7() { ConArbitro = rb1Arbitro.Checked };

                    if (rb1Arbitro.Checked)
                        lstJuezTemp.Add(juez2);

                }
                if (rbCanchaFutbol11.Checked) 
                { 
                    cancha = new CanchaFutbol11() {ConArbitro = rb1Arbitro.Checked, ConJuecesDeLinea = rb3Arbitros.Checked };

                    if (rb1Arbitro.Checked)
                    { 
                        lstJuezTemp.Add(juez2);
                        lstJuezTemp.Add(juez3);
                    }

                }

                DateTime inicio = dateTimePicker1.Value;

                int hour = int.Parse(comboBox1.SelectedItem.ToString().Split(new char[] { ':' })[0]);

                



                polideportivo.AlquilarCancha(cancha, new DateTime(inicio.Year, inicio.Month, inicio.Day, hour, 0, 0), new DateTime(inicio.Year, inicio.Month, inicio.Day, hour, 0, 0).AddHours(1), lstJuezTemp );

                mostrarResultados();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
