using System.ComponentModel.Design;

namespace Libros2024B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menu 
            string opc = "";
            Libro biblioteca = new Libro();

            do
            {
                Console.WriteLine("\nB I B L I O T E C A   C U T\n");
                Console.WriteLine("Menú:");
                Console.WriteLine("1 - Añadir libro");
                Console.WriteLine("2 - Mostrar libros");
                Console.WriteLine("3 - Buscar libro");
                Console.WriteLine("4 - Borrar libro");
                Console.WriteLine("5 - Salir");

                opc = Console.ReadLine();

                switch (opc) {
                    case "1":
                        // añadir libro
                        biblioteca.addLibros();
                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se dejara de mostrar
                        Console.Clear(); // que limpie la consola 
                        break;
                    case "2":
                        // mostrar libros
                        biblioteca.displayLibros();
                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se detara de mostrar
                        Console.Clear();
                        break;
                    case "3":
                        // buscar libros 
                        Console.WriteLine("Ingresa el isbn del libro a buscar: ");
                        string isbn = Console.ReadLine();
                        string resp = biblioteca.buscarLibros(isbn);

                        if (resp != "")
                        {
                            Console.WriteLine($"Libro: {resp} en existencia.");
                        }
                        else {
                            Console.WriteLine("El libro no esxiste.");
                        }

                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se detara de mostrar
                        Console.Clear();

                        break;
                    case "4":
                        //borrar libros
                        Console.WriteLine("Ingresa el isbn del libro a borrar: ");
                        string isbnB = Console.ReadLine();
                       

                        if (biblioteca.eliminarLibro(isbnB) != "")
                        {
                            Console.WriteLine("El libro se ha eliminado.");

                        }
                        else
                        {
                            Console.WriteLine("El libro no esxiste.");
                        }

                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se detara de mostrar
                        Console.Clear();
                        break;
                    case "5":
                        // salir 
                        Console.WriteLine("Bye!.");
                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se detara de mostrar
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Error. Opcion invalida.");
                        Console.ReadKey(); // hasta que el usuario introduzca una telca, se detara de mostrar
                        Console.Clear();
                        break;
                }


            } while (opc != "5");
        }
    }
}
