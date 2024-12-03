namespace Bucles2024B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // uso de metodos 
            usoDeBreak();
            usoDeContinue();
            usoDeBucleFor();
            usoDeBucleForEach();
        }

        private static void usoDeBreak() {
            int i = 1;
            Console.WriteLine("Metodo de uso de break.\n");

            while (i < 10) {

                if (i == 5) {
                    break;
                }

                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\nFin de uso de Break.\n");
            Console.WriteLine("----------------------------------------");

        }

        private static void usoDeContinue() {
            Console.WriteLine("Metodo de uso de Continue.\n");
            int i = 0;

            while (i < 10) {
                // i++ se pone arriba porque puede caer en un bucle infinito 
                i++;

                if (i % 2 == 0) {
                    // va a imprimir solo los impares porque los pares caen en el continue y brinca el resto del codigo
                    continue;
                }

                Console.WriteLine(i);
            }
            Console.WriteLine("\nFin de uso de Continue.\n");
            Console.WriteLine("----------------------------------------");

        }

        private static void usoDeBucleFor() {
            Console.WriteLine("Metodo bucle for\n");

            for (int i = 0; i <= 5; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFin de uso de For.\n");
            Console.WriteLine("----------------------------------------");

        }

        private static void usoDeBucleForEach() {
            Console.WriteLine("Metodo bucle foreach\n");
            
            // arreglo de strings 
            string[] nombres = { "Arely","Alexis","Bere","Axel" };

            // tipo de dato a iterar + variable + in + arreglo 
            foreach (string nom in nombres) { 
                // imprimir y recorrer todos los lugares de mi arreglo 
                Console.WriteLine(nom);
            }

            Console.WriteLine("\nFin de uso de Foreach.\n");
            Console.WriteLine("----------------------------------------");

        }
    }
}