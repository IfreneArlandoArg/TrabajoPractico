using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    public class Cafeteria
    {
        private List<MáquinaDeCafé> maquinas;

        public Cafeteria()
        {
            maquinas = new List<MáquinaDeCafé>();
        }

        public void AgregarMáquina(MáquinaDeCafé maquina)
        {
            maquinas.Add(maquina);
        }

        public List<MáquinaDeCafé> lstMaquinas() 
        { 
          return maquinas;
        }

        public double ObtenerRecaudacionTotal()
        {
            return maquinas.Sum(m => m.Recaudacion);
        }

        public Dictionary<string, double> ObtenerRecaudacionPorMáquina()
        {
            return maquinas.ToDictionary(m => m.Id, m => m.Recaudacion);
        }

        public MáquinaDeCafé ObtenerMáquinaQueMásCafeSirvió()
        {
            return maquinas.OrderByDescending(m => m.CantidadCafesServidos).FirstOrDefault();
        }

        public MáquinaDeCafé ObtenerMáquinaQueMenosCafeSirvió()
        {
            return maquinas.OrderBy(m => m.CantidadCafesServidos).FirstOrDefault();
        }

        public MáquinaDeCafé ObtenerMáquinaQueMásDineroRecaudó()
        {
            return maquinas.OrderByDescending(m => m.Recaudacion).FirstOrDefault();
        }

        public MáquinaDeCafé ObtenerMáquinaQueMenosDineroRecaudó()
        {
            return maquinas.OrderBy(m => m.Recaudacion).FirstOrDefault();
        }

        public TipoCafe ObtenerCafeQueMásVecesSeSirvió()
        {
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .OrderByDescending(g => g.Sum(m => m.CantidadCafesServidos))
                           .First().Key;
        }

        public TipoCafe ObtenerCafeQueMenosVecesSeSirvió()
        {
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .OrderBy(g => g.Sum(m => m.CantidadCafesServidos))
                           .First().Key;
        }

        public TipoCafe ObtenerCafeQueMayorRecaudacionDejó()
        {
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .OrderByDescending(g => g.Sum(m => m.Recaudacion))
                           .First().Key;
        }

        public TipoCafe ObtenerCafeQueMenosRecaudacionDejó()
        {
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .OrderBy(g => g.Sum(m => m.Recaudacion))
                           .First().Key;
        }

        public Dictionary<TipoCafe, double> ObtenerPorcentajeVentasPorCafe()
        {
            double totalVentas = maquinas.Sum(m => m.CantidadCafesServidos);
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .ToDictionary(g => g.Key, g => (g.Sum(m => m.CantidadCafesServidos) / totalVentas) * 100);
        }

        public Dictionary<string, double> ObtenerPorcentajeVentasPorMáquina()
        {
            double totalVentas = maquinas.Sum(m => m.CantidadCafesServidos);
            return maquinas.ToDictionary(m => m.Id, m => (m.CantidadCafesServidos / totalVentas) * 100);
        }

        public Dictionary<TipoCafe, double> ObtenerPorcentajeRecaudacionPorCafe()
        {
            double totalRecaudacion = ObtenerRecaudacionTotal();
            return maquinas.GroupBy(m => m.TipoCafe.Tipo)
                           .ToDictionary(g => g.Key, g => (g.Sum(m => m.Recaudacion) / totalRecaudacion) * 100);
        }

        public Dictionary<string, double> ObtenerPorcentajeRecaudacionPorMáquina()
        {
            double totalRecaudacion = ObtenerRecaudacionTotal();
            return maquinas.ToDictionary(m => m.Id, m => (m.Recaudacion / totalRecaudacion) * 100);
        }

        public MáquinaDeCafé ObtenerMáquinaQueMayorCantidadVecesSeRecargó()
        {
            return maquinas.OrderByDescending(m => m.VecesRecargada).FirstOrDefault();
        }
    }
}