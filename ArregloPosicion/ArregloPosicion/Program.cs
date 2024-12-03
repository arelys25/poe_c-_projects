using System.Reflection.Metadata;

namespace ArregloPosicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de datos que tendra tu arreglo:");
            int tam = Convert.ToInt32 (Console.ReadLine());

            int[] arreglo =new int[tam];
            // arreglo de booleanos para validar si un numero ya fue o no contado
            bool[] contado = new bool[tam];

            /*
            int num;
            int sig;
            int [] contador = new int[tam];
            int cont = 0;
            */

            // que pregunte segun la cantidad de datos que tenga el arreglo 
            for (int i = 0;i < tam;i++) {
                Console.WriteLine("\nIngresa un numero:");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            // mostrar el arreglo
            Console.WriteLine("\nArreglo:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Posicion "+i+" = " + arreglo[i]);
            }

            /*
             *0 - 2
             *1 - 4
             *2 - 6
             *3 - 8
             */

            for (int i = 0; i < tam; i++)
            {
                // if contado[i] = false, que entre al if, si es verdadero quiere decir que el numero ya se conto
                if (contado[i] == false)
                {
                    int conteo = 1;
                    // se brinca una posicion para compararla con la sigiente
                    for (int j = i + 1; j < tam; j++)
                    {
                        if (arreglo[i] == arreglo[j])
                        {
                            conteo++;
                            contado[j] = true;
                        }

                        // si no coincide, no entra al if y ahora j vale uno mas, y compara a arreglo[i] con el siguiente valor de arreglo[j]
                    }
                    Console.WriteLine($"Número {arreglo[i]} se repite {conteo} veces");
                }
            }

            // intento fallido 
            /*
            for (int i = 0; i < arreglo.Length; i++) {
                num = arreglo[i];
                

                for (int a = 0; a < arreglo.Length; a++) {
                    if (num == arreglo[a]) {
                        contador[i] = cont++;
                    }
                }

                Console.WriteLine("El numero " + num+" se repite " + contador[i]+" veces.");
            }
            */
        }
    }
}
