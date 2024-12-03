namespace Arreglos2024BArely
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array (arreglo)
            string[] pilotos = new string[4] {"Amaite","Arely","Alexis","Martin"};

            // imprimir Arely 
            Console.WriteLine(pilotos[1]+"\n");

            // cambiar valor
            pilotos[1] = "Sinai";
            Console.WriteLine(pilotos[1] + "\n");


            for (int i = 0;i < pilotos.Length; i++) {
                Console.WriteLine("Piloto "+i+": "+pilotos[i]);
            }

            Console.WriteLine();

            string[] pilotos2 = new string[4];
            // aqui no se crea un nuevo arreglo, simplemente apunta al arreglo 1, no se copian los datos asi
            //pilotos2 = pilotos;
            pilotos[3] = "Cesar";

            for (int i = 0; i < pilotos2.Length; i++)
            {
                Console.WriteLine("Piloto2 " + i + ": " + pilotos2[i]);
            }
            Console.WriteLine();

            // para copiar una arreglo correctamente tenemos que copiar dato por dato 
            for (int i = 0; i < pilotos.Length; i++)
            {
                pilotos2[i] = pilotos[i];
            }
            Console.WriteLine();

            // no se va a imprimir porque no se copio en el for anterior 
            pilotos[3] = "Ricardo";

            for (int i = 0; i < pilotos2.Length; i++)
            {
                Console.WriteLine("Piloto2 " + i + ": " + pilotos2[i]);
            }
            Console.WriteLine("------------------------------------------------");

            foreach (string nombrePiloto in pilotos) {
                Console.WriteLine(nombrePiloto); 
            }

        }
    }
}