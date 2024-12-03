using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros2024B
{
    internal class Libro
    {
        // Crear coleccion de datos 
        SortedList libros = new SortedList();

        // crear metodos 

        public void addLibros()
        {
            Console.WriteLine("Ingresa el isbn del libro: ");
            string isbn = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del libro: ");
            string nombre = Console.ReadLine();

            if (buscarLibros(isbn) == "") // si regresa cadena vacia es que el libro no existe
            {
                libros.Add(isbn, nombre); // añadirlo a la coleccion 
                Console.WriteLine("Libro añadido.");
            }
            else { 
                Console.WriteLine("El libro que deseas añadir ya existe.");

            }


        }

        public void displayLibros()
        {
            if (libros.Count > 0) // ver que si haya libros en la coleccion
            {
                foreach (object isbn in libros.Keys)
                {
                    Console.WriteLine($"Isbn: {isbn} | Libro: {libros[isbn]}\n");
                }
            }
        }

        public string buscarLibros(string isbn)
        {
            if (libros.Count > 0) // ver que si haya libros en la coleccion
            {
                if (libros.ContainsKey(isbn))
                {
                    // que retorne el libro en la posicion donde este el isbn
                    return libros[isbn]+""; // pone una cadena vacia para convertirlo a string 
                }
                else
                {
                    return "";
                }

            }
            else {
                return "";
            }
        }

        public string eliminarLibro(string isbn) {
            if (libros.Count > 0) {
                if (buscarLibros(isbn) != "") { 
                    libros.Remove(isbn);
                    return isbn;
                }
                else
                {
                    return "";
                }

            } else { 
                return ""; 
            }
        }
    }
}
