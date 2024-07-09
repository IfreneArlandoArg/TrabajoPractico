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

        int CantRecargasSurtidorNormal = 0;
        int CantRecargasSurtidorSuper = 0;
        int CantRecargasSurtidorPremium = 0;

        List<Venta> lstVentas = new List<Venta>();

        List<Venta> lstVentasNaftaNormal = new List<Venta>();
        List<Venta> lstVentasNaftaSuper = new List<Venta>();
        List<Venta> lstVentasNaftaPremium = new List<Venta>();

        List<string> dataReporteVentas = new List<string>();

        public List<string> getListdataReporteVentas() 
        {
            dataReporteVentas.Clear();

            

            dataReporteVentas.Add(Reporte());
            dataReporteVentas.Add("\n\n");
            dataReporteVentas.Add(recaudacionTotalString());
            dataReporteVentas.Add("\n");
            dataReporteVentas.Add(recaudacionTotalNormalString());
            dataReporteVentas.Add(recaudacionTotalSuperString());
            dataReporteVentas.Add(recaudacionTotalPremiumString());
            dataReporteVentas.Add("\n");
            dataReporteVentas.Add(surtidorConMasRecaudaccion());
            dataReporteVentas.Add(surtidorConMenosRecaudacion());
            dataReporteVentas.Add(surtidorConMasClientes());
            foreach (string s in porcentajeVentaCadaTipoNafta()) 
            {
                dataReporteVentas.Add(s);
            }
            foreach (string s in porcentajeRecaudacionCadaTipoNafta())
            {
                dataReporteVentas.Add(s);
            }
            dataReporteVentas.Add(surtidorConMayorCantRecargas());
            foreach (string s in promedioVentaCadaTipoNafta())
            {
                dataReporteVentas.Add(s);
            }
            foreach (string s in promedioRecaudacionCadaTipoNafta())
            {
                dataReporteVentas.Add(s);
            }


            return dataReporteVentas;
        }

        string surtidorConMayorCantRecargas() 
        {
            int surtidorConMayorCantRecargas = Math.Max(Math.Max(CantRecargasSurtidorNormal, CantRecargasSurtidorSuper), CantRecargasSurtidorPremium);

            string tipo = "Normal";

            if (surtidorConMayorCantRecargas == CantRecargasSurtidorSuper)
                tipo = "Súper";
            if (surtidorConMayorCantRecargas == CantRecargasSurtidorPremium)
                tipo = "Premium";

            return $"Surtidor con mayor cantidad recargas - {tipo} : {surtidorConMayorCantRecargas} Recarga(s).";        
        }

        public bool cantidadLitroDisponible(int pcantLitro, string pTipo)
        {
            int tempVar = CantNaftaNormalDisponible;


            if (pTipo == "Súper")
                tempVar = CantNaftaSuperDisponible;

            if (pTipo == "Premium")
                tempVar = CantNaftaPremiumDisponible;

            return pcantLitro <= tempVar;
        }

        public void AddVenta(Venta v)
        {
            if (v.Tipo == "Normal")
            {
                CantNaftaNormalDisponible -= v.CantidadEnLitro;

                if (CantNaftaNormalDisponible == 0)
                    CantRecargasSurtidorNormal++;
                
                
                lstVentasNaftaNormal.Add(v);
            }

            if (v.Tipo == "Súper")
            { 
                CantNaftaSuperDisponible -= v.CantidadEnLitro;

                if (CantNaftaSuperDisponible == 0)
                    CantRecargasSurtidorSuper++;

                lstVentasNaftaSuper.Add(v);
            }

            if (v.Tipo == "Premium")
            { 
                CantNaftaPremiumDisponible -= v.CantidadEnLitro;

                if (CantNaftaPremiumDisponible == 0)
                    CantRecargasSurtidorPremium++;

                lstVentasNaftaPremium.Add(v);
            }

            lstVentas.Add(v);

          

        }

        string Reporte()
        {
            return $"Reporte - {DateTime.Now}";
        }


        double CalcularRecaudacion(List<Venta> plstVentas)
        {
            double total = 0;
            
            if (plstVentas.Count > 0)
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
            
            return CalcularRecaudacion(lstVentasNaftaNormal);
        }

        double CalcularRecaudacionTotalTipoSuper()
        {
            
            return CalcularRecaudacion(lstVentasNaftaSuper);
        }

        double CalcularRecaudacionTotalTipoPremium()
        {
            return CalcularRecaudacion(lstVentasNaftaPremium);
        }

        public string recaudacionTotalNormalString() 
        {
            return $"Recaudación total Nafta Normal : {CalcularRecaudacionTotalTipoNormal()} ARS $";
        }

        public string recaudacionTotalSuperString()
        {
            return $"Recaudación total Nafta Super : {CalcularRecaudacionTotalTipoSuper()} ARS $";
        }

        public string recaudacionTotalPremiumString()
        {
            return $"Recaudación total Nafta Premium : {CalcularRecaudacionTotalTipoPremium()} ARS $";
        }

        public string recaudacionTotalString()
        {
            return $"Recaudación total estación de servicio : {CalcularRecaudacionTotalTodosTiposConfundidos()} ARS $";
               
    
                
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
        public string surtidorConMasRecaudaccion() 
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


        public string surtidorConMenosRecaudacion() 
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

        public string surtidorConMasClientes() 
        {
            string tipoSustidorConMasCliente = "Normal";

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

         string[] porcentajeVentaCadaTipoNafta()
        {
            

            double porcentajeVentaNaftaNormal = porcentajeVenta(lstVentasNaftaNormal);
            double porcentajeVentaNaftaSuper = porcentajeVenta(lstVentasNaftaSuper);
            double porcentajeVentaNaftaPremium = porcentajeVenta(lstVentasNaftaPremium);
            
            return $"Porcentaje de venta nafta Normal : {porcentajeVentaNaftaNormal}%;Porcentaje de venta nafta Super : {porcentajeVentaNaftaSuper}%;Porcentaje de venta nafta Premium : {porcentajeVentaNaftaPremium}%;".Split(new char[]{ ';'});
        }

        string[] porcentajeRecaudacionCadaTipoNafta()
        {
            

            double porcentajeRecaudacionNaftaNormal = porcentajeRecaudacion(lstVentasNaftaNormal);
            double porcentajeRecaudacionNaftaSuper = porcentajeRecaudacion(lstVentasNaftaSuper);
            double porcentajeRecaudacionNaftaPremium = porcentajeRecaudacion(lstVentasNaftaPremium);
            
            return $"Porcentaje de Recaudacion nafta Normal : {porcentajeRecaudacionNaftaNormal}%\nPorcentaje de Recaudacion nafta Super : {porcentajeRecaudacionNaftaSuper}%\nPorcentaje de Recaudacion nafta Premium : {porcentajeRecaudacionNaftaPremium}%\n".Split(new char[] { '\n' });
        }

        //Calcular promedio ventas por surtidor (C/U)...
        double promedioVenta(List<Venta> plstBulk)
        {
            double result = 0;

            if (plstBulk.Count > 0)
                result = CalcularVentaTotalEnLitro(plstBulk) / plstBulk.Count;

          return result;
        }

        string[] promedioVentaCadaTipoNafta()
        {
            

            double promedioVentaNaftaNormal = promedioVenta(lstVentasNaftaNormal);
            double promedioVentaNaftaSuper = promedioVenta(lstVentasNaftaSuper);
            double promedioVentaNaftaPremium = promedioVenta(lstVentasNaftaPremium);
            
            return $"Promedio de venta nafta Normal : {promedioVentaNaftaNormal} litros.\nPromedio de venta nafta Super : {promedioVentaNaftaSuper} litros.\nPromedio de venta nafta Premium : {promedioVentaNaftaPremium} litros.\n".Split(new char[] {'\n'});           
        }


        //Calcular promedio recaudacion por surtidor (C/U)...
        double promedioRecaudacion(List<Venta> plstBulk)
        {
          double result = 0;

            if (plstBulk.Count > 0)
                result = CalcularRecaudacion(plstBulk) / plstBulk.Count;
        
            return result;
        }

        string[] promedioRecaudacionCadaTipoNafta()
        {
            

            double promedioRecaudacionNaftaNormal = promedioRecaudacion(lstVentasNaftaNormal);
            double promedioRecaudacionNaftaSuper = promedioRecaudacion(lstVentasNaftaSuper);
            double promedioRecaudacionNaftaPremium = promedioRecaudacion(lstVentasNaftaPremium);
            
            return $"Promedio de Recaudacion nafta Normal : {promedioRecaudacionNaftaNormal} ARS $.\nPromedio de Recaudacion nafta Super : {promedioRecaudacionNaftaSuper} ARS $.\nPromedio de Recaudacion nafta Premium : {promedioRecaudacionNaftaPremium} ARS $.\n".Split(new char[] {'\n'});              
        }

       

    }
}