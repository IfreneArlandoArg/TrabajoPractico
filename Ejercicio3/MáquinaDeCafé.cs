using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    public class MáquinaDeCafé
    {
        public string Id { get; set; }
        public Cafe TipoCafe { get; set; }
        public double CapacidadLitros { get; set; }
        public double CafeDisponible { get; set; }
        public int CantidadCafesServidos { get; set; }
        public double Recaudacion { get; set; }
        public int VecesRecargada { get; set; }

        public MáquinaDeCafé(string id, Cafe tipoCafe, double capacidadLitros)
        {
            Id = id;
            TipoCafe = tipoCafe;
            CapacidadLitros = capacidadLitros;
            CafeDisponible = capacidadLitros;
            CantidadCafesServidos = 0;
            Recaudacion = 0;
            VecesRecargada = 0;
        }

        public bool ServirCafe(Vaso vaso)
        {
            double volumenLitros = vaso.Volumen / 1000.0;
            if (CafeDisponible >= volumenLitros)
            {
                CafeDisponible -= volumenLitros;
                CantidadCafesServidos++;
                Recaudacion += volumenLitros * TipoCafe.PrecioPorLitro;
                return true;
            }
            else
            {
                Recargar();
                return false;
            }
        }

        public void Recargar()
        {
            CafeDisponible = CapacidadLitros;
            VecesRecargada++;
        }
    }
}