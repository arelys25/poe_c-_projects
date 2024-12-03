using System;

namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mes;

            do
            {
                Console.WriteLine("Ingrese un mes o '0' para salir del programa:\n");
                mes = Console.ReadLine().Trim().ToLower(); // ToLower para convertir todo en minúscular y que lo pueda detectar el switch case
                // .Trim elimina cualquier espacio en blanco al principio y al final de la cadena
                Console.WriteLine(); // salto de línea               

                switch (mes)
                {
                    case "0":              
                        break;

                    case "enero":
                    case "marzo":
                    case "mayo":
                    case "julio":
                    case "agosto":
                    case "octubre":
                    case "diciembre":
                        Console.WriteLine(mes + " tiene 31 días.\n");
                        break;

                    case "febrero":
                        Console.WriteLine(mes + " tiene 28 días.\n");
                        break;

                    case "abril":
                    case "junio":
                    case "septiembre":
                    case "noviembre":
                        Console.WriteLine(mes + " tiene 30 días.\n");
                        break;

                    default:
                        Console.WriteLine("Error. Mes inválido\n");
                        break;

                }
            } while (mes != "0");

            Console.WriteLine("Fin del programa.");

        }   
    }
}