namespace NotNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionHasValue();

            funcionOrDefault();

            funcionHasValueTry();

        }

        static void funcionOrDefault()
        {
            Console.WriteLine("\nGet Value or default funcion");
            int? a = null;
            bool? b = null;

            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            // GetValueOrDefault da el valor de una variable pero, si esta nulo, va a dar 0, false, 0.0 (depende el tipo de variable)
            a = 25;
            b = true;
            Console.WriteLine("Con valores establecidos:");
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

        }

        static void funcionHasValue()
        {
            Console.WriteLine("\nHas Value funcion");
            int? a = null;
            //a = 10;


            if (a.HasValue)
            { // HasValue es booleano y pregunta si tiene o no valor una variable

                Console.WriteLine(a.Value); // .Value da el valor de la variable

            }
            else
            {
                Console.WriteLine("Valor nulo");
            }

        }

        static void funcionHasValueTry()
        {
            Console.WriteLine("\nOperador Value funcion");

            int? x = null;
            int y = 0;

            try
            {   
                // x = 25;

                y = x.Value; // funcion no valida porque y no puede almacenar valores nulos

                Console.WriteLine(y);

            } catch
            {
                Console.WriteLine("Operacion no valida.");
            }

        }
    }
}
