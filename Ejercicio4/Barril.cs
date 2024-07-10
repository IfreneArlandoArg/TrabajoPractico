using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    public class Barril
    {
        public string Id { get; set; }
        public Cerveza TipoCerveza { get; set; }
        public double CapacidadLitros { get; set; }
        public double CervezaDisponible { get; set; }
        public int CantidadVasosServidos { get; set; }
        public double Recaudacion { get; set; }

        List<Vaso> lstVasosServidos;

        public Barril(string id, Cerveza tipoCerveza, double capacidadLitros)
        {
            Id = id;
            TipoCerveza = tipoCerveza;
            CapacidadLitros = capacidadLitros;
            CervezaDisponible = capacidadLitros;
            CantidadVasosServidos = 0;
            Recaudacion = 0;

            lstVasosServidos = new List<Vaso>();
        }

        public bool ServirCerveza(Vaso vaso)
        {
            if (CervezaDisponible >= vaso.Volumen)
            {
                CervezaDisponible -= vaso.Volumen;
                CantidadVasosServidos++;
                Recaudacion += vaso.Volumen * TipoCerveza.PrecioPorLitro * vaso.Incremento;

                lstVasosServidos.Add(vaso);

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Vaso> ObtenerListaVasosServidos()
        {
            return lstVasosServidos;
        }
    }
}