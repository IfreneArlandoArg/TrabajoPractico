using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AfterOffice afterOffice = new AfterOffice();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Agregar barriles
                afterOffice.AgregarBarril(new Barril("B1 - Rubia Nacional", new Cerveza(TipoCerveza.RubiaNacional, 50), 50));
                afterOffice.AgregarBarril(new Barril("B2 - Negra Nacional", new Cerveza(TipoCerveza.NegraNacional, 58), 60));
                afterOffice.AgregarBarril(new Barril("B3 - Rubia Extranjera", new Cerveza(TipoCerveza.RubiaExtranjera, 65), 70));


            }
            catch (Exception ex){ MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }

        void MostrarResultadosLsBox() 
        {
            lsbVentasInfos.Items.Clear();

            lsbVentasInfos.Items.Add("Recaudación total: " + afterOffice.CalcularRecaudacionTotal());

            var barrilMasCervezaSirvio = afterOffice.ObtenerBarrilQueMasCervezaSirvio();
            lsbVentasInfos.Items.Add($"Barril que más cerveza sirvió: {barrilMasCervezaSirvio.Id} con {barrilMasCervezaSirvio.CapacidadLitros - barrilMasCervezaSirvio.CervezaDisponible} litros");

            var barrilMenosCervezaSirvio = afterOffice.ObtenerBarrilQueMenosCervezaSirvio();
            lsbVentasInfos.Items.Add($"Barril que menos cerveza sirvió: {barrilMenosCervezaSirvio.Id} con {barrilMenosCervezaSirvio.CapacidadLitros - barrilMenosCervezaSirvio.CervezaDisponible} litros");

            var barrilMasDineroRecaudo = afterOffice.ObtenerBarrilQueMasDineroRecaudo();
            lsbVentasInfos.Items.Add($"Barril que más dinero recaudó: {barrilMasDineroRecaudo.Id} con {barrilMasDineroRecaudo.Recaudacion} de recaudación");

            lsbVentasInfos.Items.Add("Cerveza más vendida: " + afterOffice.ObtenerCervezaMasVendida());
            lsbVentasInfos.Items.Add("Cerveza que generó más ganancia: " + afterOffice.ObtenerCervezaQueGeneroMasGanancia());
            lsbVentasInfos.Items.Add("Cerveza que se vendió mayor cantidad de litros: " + afterOffice.ObtenerCervezaQueSeVendioMayorCantidadLitros());
            lsbVentasInfos.Items.Add("Cerveza que se vendió menor cantidad de litros: " + afterOffice.ObtenerCervezaQueSeVendioMenorCantidadLitros());
            lsbVentasInfos.Items.Add("Tipo de vaso más solicitado: " + afterOffice.ObtenerTipoVasoMasSolicitado());

            var porcentajeVentaPorCerveza = afterOffice.CalcularPorcentajeVentaPorCerveza();
            foreach (var porcentaje in porcentajeVentaPorCerveza)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de ventas de cerveza {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeRecaudacionPorCerveza = afterOffice.CalcularPorcentajeRecaudacionPorCerveza();
            foreach (var porcentaje in porcentajeRecaudacionPorCerveza)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de recaudación de cerveza {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeVentaPorBarril = afterOffice.CalcularPorcentajeVentaPorBarril();
            foreach (var porcentaje in porcentajeVentaPorBarril)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de ventas de barril {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeRecaudacionPorBarril = afterOffice.CalcularPorcentajeRecaudacionPorBarril();
            foreach (var porcentaje in porcentajeRecaudacionPorBarril)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de recaudación de barril {porcentaje.Key}: {porcentaje.Value}%");
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                Vaso tempTipoVaso = new Vaso(TipoVaso.Chopp);

                
                if(rbVaso.Checked)
                    tempTipoVaso = new Vaso(TipoVaso.Vaso);
                if(rbJarra.Checked)
                    tempTipoVaso = new Vaso(TipoVaso.Jarra);

                if (rbRubiaNacional.Checked)
                    afterOffice.getLstBarriles()[0].ServirCerveza(tempTipoVaso);
                if(rbNegraNacional.Checked)
                    afterOffice.getLstBarriles()[1].ServirCerveza(tempTipoVaso);
                if(rbRubiaExtranjera.Checked)
                    afterOffice.getLstBarriles()[2].ServirCerveza(tempTipoVaso);

                MostrarResultadosLsBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
