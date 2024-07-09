using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cafeteria cafeteria = new Cafeteria();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Agregar máquinas
                cafeteria.AgregarMáquina(new MáquinaDeCafé("M1 - Arabigo", new Cafe(TipoCafe.Arabigo, 50), 10));
                cafeteria.AgregarMáquina(new MáquinaDeCafé("M2 - Robusto", new Cafe(TipoCafe.Robusto, 58), 15));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }

        void MostrarResultadosLstBox() 
        { 
            lsbVentasInfos.Items.Clear();

            lsbVentasInfos.Items.Add("Recaudación total: " + cafeteria.ObtenerRecaudacionTotal());

            var recaudacionPorMaquina = cafeteria.ObtenerRecaudacionPorMáquina();
            foreach (var recaudacion in recaudacionPorMaquina)
            {
                lsbVentasInfos.Items.Add($"Máquina {recaudacion.Key} recaudó: {recaudacion.Value}");
            }

            lsbVentasInfos.Items.Add("Máquina que más café sirvió: " + cafeteria.ObtenerMáquinaQueMásCafeSirvió().Id);
            lsbVentasInfos.Items.Add("Máquina que menos café sirvió: " + cafeteria.ObtenerMáquinaQueMenosCafeSirvió().Id);
            lsbVentasInfos.Items.Add("Máquina que más dinero recaudó: " + cafeteria.ObtenerMáquinaQueMásDineroRecaudó().Id);
            lsbVentasInfos.Items.Add("Máquina que menos dinero recaudó: " + cafeteria.ObtenerMáquinaQueMenosDineroRecaudó().Id);
            lsbVentasInfos.Items.Add("Café que más veces se sirvió: " + cafeteria.ObtenerCafeQueMásVecesSeSirvió());
            lsbVentasInfos.Items.Add("Café que menos veces se sirvió: " + cafeteria.ObtenerCafeQueMenosVecesSeSirvió());
            lsbVentasInfos.Items.Add("Café que mayor recaudación dejó: " + cafeteria.ObtenerCafeQueMayorRecaudacionDejó());
            lsbVentasInfos.Items.Add("Café que menos recaudación dejó: " + cafeteria.ObtenerCafeQueMenosRecaudacionDejó());

            var porcentajeVentasPorCafe = cafeteria.ObtenerPorcentajeVentasPorCafe();
            foreach (var porcentaje in porcentajeVentasPorCafe)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de ventas de café {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeVentasPorMáquina = cafeteria.ObtenerPorcentajeVentasPorMáquina();
            foreach (var porcentaje in porcentajeVentasPorMáquina)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de ventas de máquina {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeRecaudacionPorCafe = cafeteria.ObtenerPorcentajeRecaudacionPorCafe();
            foreach (var porcentaje in porcentajeRecaudacionPorCafe)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de recaudación de café {porcentaje.Key}: {porcentaje.Value}%");
            }

            var porcentajeRecaudacionPorMáquina = cafeteria.ObtenerPorcentajeRecaudacionPorMáquina();
            foreach (var porcentaje in porcentajeRecaudacionPorMáquina)
            {
                lsbVentasInfos.Items.Add($"Porcentaje de recaudación de máquina {porcentaje.Key}: {porcentaje.Value}%");
            }

            lsbVentasInfos.Items.Add("Máquina que mayor cantidad de veces se recargó: " + cafeteria.ObtenerMáquinaQueMayorCantidadVecesSeRecargó().Id);




        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                Vaso tempVaso = new Vaso(TipoVaso.Chico);

                if (rbMediano.Checked)
                    tempVaso = new Vaso(TipoVaso.Mediano);

                if (rbGrande.Checked)
                    tempVaso = new Vaso(TipoVaso.Grande);


                if (rbArabigo.Checked) 
                    cafeteria.lstMaquinas()[0].ServirCafe(tempVaso); 
                
                if(rbRobusto.Checked)
                    cafeteria.lstMaquinas()[1].ServirCafe(tempVaso);


                MostrarResultadosLstBox();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
