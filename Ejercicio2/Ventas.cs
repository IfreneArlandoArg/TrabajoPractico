using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Ventas
    {
        int CantNaftaNormalDisponible = 2000;
        int CantNaftaSuperDisponible = 2000;
        int CantNaftaPremiumDisponible = 2000;

        List<Venta> lstVentas = new List<Venta>();

        List<Venta> lstVentasNaftaNormal = new List<Venta>();
        List<Venta> lstVentasNaftaSuper = new List<Venta>();
        List<Venta> lstVentasNaftaPremium = new List<Venta>();

        void UpdateListaNaftaNormalSuperPremium()
        {
            foreach (Venta v in lstVentas) 
            {
                if (v.Tipo == "Normal")
                    lstVentasNaftaNormal.Add(v);

                if (v.Tipo == "Súper")
                    lstVentasNaftaSuper.Add(v);

                if (v.Tipo == "Premium")
                    lstVentasNaftaPremium.Add(v);
            }

        }

        double CalcularRecaudacion(List<Venta> plstVentas) 
        {
            double total = 0;

            foreach (Venta v in plstVentas)
            {
                total += v.Precio;
            }

            return total;
        }

        double CalcularRecaudacionTotalTodosTiposConfundidos() 
        { 
          
          return CalcularRecaudacion(lstVentas);
        }

        double CalcularRecaudacionTotalTipoNormal()
        {
            UpdateListaNaftaNormalSuperPremium();
            return CalcularRecaudacion(lstVentasNaftaNormal);
        }

        double CalcularRecaudacionTotalTipoSuper()
        {
            UpdateListaNaftaNormalSuperPremium();
            return CalcularRecaudacion(lstVentasNaftaSuper);
        }

        double CalcularRecaudacionTotalTipoPremium()
        {
            UpdateListaNaftaNormalSuperPremium();
            return CalcularRecaudacion(lstVentasNaftaPremium);
        }

        double RecaudacionMasGrande(double pNormal,double pSuper,double pPremium) 
        {
            return Math.Max(Math.Max(pNormal,pSuper), pPremium);
        }

        int MaxCantidadCliente(int pCantNormal, int pCantSuper, int pCantPremium)  
        {
           return Math.Max(Math.Max(pCantNormal,pCantSuper), pCantPremium);
        }

        double RecaudacionMenosGrande(double pNormal, double pSuper, double pPremium) 
        {
            return Math.Min(Math.Min(pNormal, pSuper), pPremium);
        }
        string surtidorConMasRecaudaccion() 
        { 

            string tipoSustidorConMasRecaudaccion = "Normal";

            double Normal = CalcularRecaudacionTotalTipoNormal();
            double Super = CalcularRecaudacionTotalTipoSuper();
            double Premium = CalcularRecaudacionTotalTipoPremium();

            double recaudacionMax = RecaudacionMasGrande(Normal,Super,Premium);

            if (recaudacionMax == Normal)
                tipoSustidorConMasRecaudaccion = "Normal";
            if (recaudacionMax == Super)
                tipoSustidorConMasRecaudaccion = "Súper";
            if (recaudacionMax == Premium)
                tipoSustidorConMasRecaudaccion = "Premium";


            return $"Sustidor con más recaudación Nafta {tipoSustidorConMasRecaudaccion} : {recaudacionMax} ARS$ ";
        
        }


        string surtidorConMenosRecaudacion() 
        {
            string tipoSustidorConMenosRecaudacion = "Normal";

            double Normal = CalcularRecaudacionTotalTipoNormal();
            double Super = CalcularRecaudacionTotalTipoSuper();
            double Premium = CalcularRecaudacionTotalTipoPremium();

            double recaudacionMin = RecaudacionMenosGrande(Normal, Super, Premium);

            if (recaudacionMin == Normal)
                tipoSustidorConMenosRecaudacion = "Normal";
            if (recaudacionMin == Super)
                tipoSustidorConMenosRecaudacion = "Súper";
            if (recaudacionMin == Premium)
                tipoSustidorConMenosRecaudacion = "Premium";


            return $"Sustidor con menos recaudación Nafta {tipoSustidorConMenosRecaudacion} : {recaudacionMin} ARS$ ";
        }

        string surtidorConMasClientes() 
        {
            string tipoSustidorConMasCliente = "Normal";

            UpdateListaNaftaNormalSuperPremium();

            int cantClienteNormal = lstVentasNaftaNormal.Count;
            int cantClienteSuper = lstVentasNaftaSuper.Count;
            int cantClientePremium = lstVentasNaftaPremium.Count;

            int cantClienteMax = MaxCantidadCliente(cantClienteNormal,cantClienteSuper, cantClientePremium);

            if (cantClienteMax == cantClienteNormal)
                tipoSustidorConMasCliente = "Normal";
            if (cantClienteMax == cantClienteSuper)
                tipoSustidorConMasCliente = "Súper";
            if (cantClienteMax == cantClientePremium)
                tipoSustidorConMasCliente = "Premium";

            return $"Sustidor con más cliente(s) {tipoSustidorConMasCliente} : {cantClienteMax} clientes ";

           

        }

        int CalcularVentaTotalEnLitro(List<Venta> plstBulk)
        {
           int total = 0;

           foreach(Venta v in plstBulk)
           {
             total += v.CantidadEnLitro;
           }

           return total;
        }

        double porcentajeVenta(List<Venta> plstBulk)
        {
          double _porcentajeVenta = 0;
          double  _porcentajeVentaTipoEspecifico = CalcularVentaTotalEnLitro(plstBulk);
          double  _porcentajeVentaTodosTipos = CalcularVentaTotalEnLitro(lstVentas);

          _porcentajeVenta = (_porcentajeVentaTipoEspecifico*100)/_porcentajeVentaTodosTipos;

          return _porcentajeVenta;    
        }

        double porcentajeRecaudacion(List<Venta> plstBulk)
        {
           return (CalcularRecaudacion(plstBulk)*100)/CalcularRecaudacionTotalTodosTiposConfundidos();
        }

        string porcentajeVentaCadaTipoNafta()
        {
            UpdateListaNaftaNormalSuperPremium();

            double porcentajeVentaNaftaNormal = porcentajeVenta(lstVentasNaftaNormal);
            double porcentajeVentaNaftaSuper = porcentajeVenta(lstVentasNaftaSuper);
            double porcentajeVentaNaftaPremium = porcentajeVenta(lstVentasNaftaPremium);
            
            return $"Porcentaje de venta nafta Normal : {porcentajeVentaNaftaNormal}%\nPorcentaje de venta nafta Super : {porcentajeVentaNaftaSuper}%\nPorcentaje de venta nafta Premium : {porcentajeVentaNaftaPremium}%\n";
        }

        string porcentajeRecaudacionCadaTipoNafta()
        {
            UpdateListaNaftaNormalSuperPremium();

            double porcentajeRecaudacionNaftaNormal = porcentajeRecaudacion(lstVentasNaftaNormal);
            double porcentajeRecaudacionNaftaSuper = porcentajeRecaudacion(lstVentasNaftaSuper);
            double porcentajeRecaudacionNaftaPremium = porcentajeRecaudacion(lstVentasNaftaPremium);
            
            return $"Porcentaje de Recaudacion nafta Normal : {porcentajeRecaudacionNaftaNormal}%\nPorcentaje de Recaudacion nafta Super : {porcentajeRecaudacionNaftaSuper}%\nPorcentaje de Recaudacion nafta Premium : {porcentajeRecaudacionNaftaPremium}%\n";
        }

        //Calcular promedio ventas por surtidor (C/U)...
        double promedioVenta(List<Venta> plstBulk)
        {
          return CalcularVentaTotalEnLitro(plstBulk)/plstBulk.Count;
        }

        string promedioVentaCadaTipoNafta()
        {
            UpdateListaNaftaNormalSuperPremium();

            double promedioVentaNaftaNormal = promedioVenta(lstVentasNaftaNormal);
            double promedioVentaNaftaSuper = promedioVenta(lstVentasNaftaSuper);
            double promedioVentaNaftaPremium = promedioVenta(lstVentasNaftaPremium);
            
            return $"Promedio de venta nafta Normal : {promedioVentaNaftaNormal}%\nPromedio de venta nafta Super : {promedioVentaNaftaSuper}.\nPromedio de venta nafta Premium : {promedioVentaNaftaPremium}.\n";           
        }


        //Calcular promedio recaudacion por surtidor (C/U)...
        

    }
}