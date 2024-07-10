﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Prestamo> Prestamos { get; set; }
        public int Sanciones { get; set; }
        public DateTime? FechaFinSancion { get; set; }

        public Cliente(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Prestamos = new List<Prestamo>();
            Sanciones = 0;
            FechaFinSancion = null;
        }

        public bool PuedePrestar()
        {
            return FechaFinSancion == null || FechaFinSancion <= DateTime.Now;
        }
    }

}
