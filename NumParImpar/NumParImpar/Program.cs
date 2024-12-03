namespace NumParImpar
{
    internal class Program
    {
        private static int num; // declarar la variable fuera del main para que lo detecte en el try 

        static void Main(string[] args)
        {        
            // CICLO PARA QUE EL USUARIO SIGA INGRESANDO NUMEROS
            do
            {
                // DETECTOR DE EXCEPCIONES
                try
                {
                    // zona donde podria pasar el error
                    Console.WriteLine("\nIngresa un numero o '0' para salir del programa:\n");
                    num = Convert.ToInt32(Console.ReadLine());

                    // IF - ELSE
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("\nIF - El numero " + num + " es par\n");
                    }
                    else
                    {
                        Console.WriteLine("\nIF - El numero " + num + " es impar\n");
                    }

                    // SWITCH CASE
                    switch (num % 2)
                    {
                        case 0:
                            Console.WriteLine("SWITCH - El numero " + num + " es par\n");
                            break;

                        default:
                            Console.WriteLine("SWITCH - El numero " + num + " es impar\n");
                            break;
                    }

                }
                catch (System.FormatException e)
                {
                    // que imprima que el string esta incorrecto 
                    Console.WriteLine(e.Message);
                }
                

            } while (num != 0);

            Console.WriteLine("Fin del programa. Bye :)");
            
        }

    }
}
