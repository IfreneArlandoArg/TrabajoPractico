﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class LibroConMaterialDigital : Libro
    {
        public int CantidadCDs { get; set; }

        public LibroConMaterialDigital(int id, string titulo, string autor, int ano, string editorial, int edicion, int cantidadCDs)
            : base(id, titulo, autor, ano, editorial, edicion)
        {
            CantidadCDs = cantidadCDs;
        }
    }

}
