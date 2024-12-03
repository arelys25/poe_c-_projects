namespace PromedioAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prom; // se crea la variable fuera del bucle para que lo detecte el "while" al hacer la condicionante

            do {
                Console.WriteLine("Ingresa tu promedio (1-10) ingrese -1 si desea salir del programa:\n");
                prom = Convert.ToDouble(Console.ReadLine());

                if (prom >= 6 && prom <= 10)
                {
                    Console.WriteLine("¡Felicidades! Aprobaste la materia.\n");
                }
                else if (prom < 6 && prom >= 5)
                {
                    Console.WriteLine("Lo siento, te irás a extra :(.\n");
                }
                else if (prom < 5 && prom > 0)
                {
                    Console.WriteLine("Chin, reprobaste :(.\n");
                }
                else if (prom == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error. El promedio que ingresaste es incorrecto.\n");
                }
            } while (prom != -1);

            
            Console.WriteLine(operadorTernario(prom," Arely "));
            
            Console.WriteLine("Fin del programa.");
        }

        static string operadorTernario (double promedio, string nombre)
        {
            string resultado = "El alumno ha ";

            // OPERADOR TERNARIO 
            // += equivale a resultado más (+) otra cosa ...
            return resultado += promedio >= 6 ? "aprobado" : "reprobado";
            // si promedio es mayor o igual a 6 (?) = "aprobado", si no (:) = "reprobado"
        }
    }
}