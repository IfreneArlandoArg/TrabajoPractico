using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class Biblioteca
    {
        List<Prestamo> Prestamos;
        
        List<Revista> Revistas;
        List<Libro> Libros;
        List<LibroConMaterialDigital> LibrosConMaterialDigital;

        List<Cliente> Clientes;
        List<Cliente> ClientesRegistrados;

        public Biblioteca()
        {
            Prestamos = new List<Prestamo>();
            Revistas = new List<Revista>();
            Libros = new List<Libro>();
            LibrosConMaterialDigital = new List<LibroConMaterialDigital>();
            Clientes = new List<Cliente>();
            ClientesRegistrados = new List<Cliente>();
        }

        public void AgregarClienteRegistrado(Cliente pCliente) 
        {
            ClientesRegistrados.Add(pCliente);
        
        }

        public List<Cliente> ObtenerClientesRegistrados() 
        {
            return ClientesRegistrados;
        }

        public void AgregarPrestamo(Prestamo pPrestamo)
        {
            Prestamos.Add(pPrestamo);
            Clientes.Add(pPrestamo.ClientePresta);
        }
        public List<Prestamo> ObtenerPrestamos()
        {
            return Prestamos;

        }

        public List<Cliente> ObtenerListaCliente() 
        { 
           return Clientes;
        }

        public void AgregarRevista(Revista pRevista)
        {
            Revistas.Add(pRevista);
        }

        public List<Revista> ObtenerRevistas()
        {
            return Revistas;
        }

        public void Prestar(List<Ejemplar> listaEjamplares)
        {
          foreach (Ejemplar ej in listaEjamplares)
          { 
            var LibroToRemove = Libros.Where(l => l.Titulo == ej.Titulo).FirstOrDefault();
               if (LibroToRemove != null)
                   Libros.Remove(LibroToRemove);
            

            var LibroCoMaterialDigitalToRemove = LibrosConMaterialDigital.Where(l => l.Titulo == ej.Titulo).FirstOrDefault();
                if(LibroCoMaterialDigitalToRemove != null)
                    LibrosConMaterialDigital.Remove(LibroCoMaterialDigitalToRemove);

            var RevistaToRemove = Revistas.Where(r => r.Titulo == ej.Titulo).FirstOrDefault();
                if (RevistaToRemove != null)
                     Revistas.Remove(RevistaToRemove);

          }
        }

        public void AgregarLibro(Libro pLibro)
        {
            Libros.Add(pLibro);
        }
        public List<Libro> ObtenerLibros() 
        { 
           return Libros;
        }

        public void AgregarLibroConMaterialDigital(LibroConMaterialDigital pLibroConMaterialDigital) 
        { 
          LibrosConMaterialDigital.Add(pLibroConMaterialDigital);
        }

        public List<LibroConMaterialDigital> ObtenerLibrosConMaterialDigital() 
        { 
          return LibrosConMaterialDigital;
        }
    }
}