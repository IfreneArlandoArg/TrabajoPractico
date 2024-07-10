using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    public class AfterOffice
    {
        private List<Barril> barriles;

        public AfterOffice()
        {
            barriles = new List<Barril>();
        }

        public List<Barril> getLstBarriles() 
        { 
           return barriles;
        }
        public void AgregarBarril(Barril barril)
        {
            barriles.Add(barril);
        }

        public double CalcularRecaudacionTotal()
        {
            return barriles.Sum(b => b.Recaudacion);
        }

        public Barril ObtenerBarrilQueMasCervezaSirvio()
        {
            return barriles.OrderByDescending(b => b.CapacidadLitros - b.CervezaDisponible).FirstOrDefault();
        }

        public Barril ObtenerBarrilQueMenosCervezaSirvio()
        {
            return barriles.OrderBy(b => b.CapacidadLitros - b.CervezaDisponible).FirstOrDefault();
        }

        public Barril ObtenerBarrilQueMasDineroRecaudo()
        {
            return barriles.OrderByDescending(b => b.Recaudacion).FirstOrDefault();
        }

        public TipoCerveza ObtenerCervezaMasVendida()
        {
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .OrderByDescending(g => g.Sum(b => b.CantidadVasosServidos))
                           .First().Key;
        }

        public TipoCerveza ObtenerCervezaQueGeneroMasGanancia()
        {
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .OrderByDescending(g => g.Sum(b => b.Recaudacion))
                           .First().Key;
        }

        public TipoCerveza ObtenerCervezaQueSeVendioMayorCantidadLitros()
        {
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .OrderByDescending(g => g.Sum(b => b.CapacidadLitros - b.CervezaDisponible))
                           .First().Key;
        }

        public TipoCerveza ObtenerCervezaQueSeVendioMenorCantidadLitros()
        {
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .OrderBy(g => g.Sum(b => b.CapacidadLitros - b.CervezaDisponible))
                           .First().Key;
        }

        public TipoVaso ObtenerTipoVasoMasSolicitado()
        {
            // Para esto, se necesita tener un contador de vasos por tipo en el after office
            var vasosServidos = new Dictionary<TipoVaso, int>();
            foreach (var barril in barriles)
            {
                // Supongamos que cada barril tiene una lista de los tipos de vasos que ha servido
                foreach (var vaso in barril.ObtenerListaVasosServidos())
                {
                    if (vasosServidos.ContainsKey(vaso.Tipo))
                    {
                        vasosServidos[vaso.Tipo]++;
                    }
                    else
                    {
                        vasosServidos[vaso.Tipo] = 1;
                    }
                }
            }
            return vasosServidos.OrderByDescending(v => v.Value).First().Key;
        }

        public Dictionary<TipoCerveza, double> CalcularPorcentajeVentaPorCerveza()
        {
            double totalVentas = barriles.Sum(b => b.CantidadVasosServidos);
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .ToDictionary(g => g.Key, g => (g.Sum(b => b.CantidadVasosServidos) / totalVentas) * 100);
        }

        public Dictionary<TipoCerveza, double> CalcularPorcentajeRecaudacionPorCerveza()
        {
            double totalRecaudacion = CalcularRecaudacionTotal();
            return barriles.GroupBy(b => b.TipoCerveza.Tipo)
                           .ToDictionary(g => g.Key, g => (g.Sum(b => b.Recaudacion) / totalRecaudacion) * 100);
        }

        public Dictionary<string, double> CalcularPorcentajeVentaPorBarril()
        {
            double totalVentas = barriles.Sum(b => b.CantidadVasosServidos);
            return barriles.ToDictionary(b => b.Id, b => (b.CantidadVasosServidos / totalVentas) * 100);
        }

        public Dictionary<string, double> CalcularPorcentajeRecaudacionPorBarril()
        {
            double totalRecaudacion = CalcularRecaudacionTotal();
            return barriles.ToDictionary(b => b.Id, b => (b.Recaudacion / totalRecaudacion) * 100);
        }
    }
}