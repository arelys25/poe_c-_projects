namespace CadenasDeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodoSubstring();
            metodoIndexOf();
            metodoRecorridoString();
            metodoMayusculasMinusculas();
            metodoStartsWithEndsWith();
            metodoPad();
            metodoTrim();
        }

        private static void metodoTrim()
        {
            // metodo que quita los espacios al inicio, al final o todos los que haya en un a cadena 
            string nombre = "   Arely Sinai Munoz Tapia   ";

            Console.WriteLine("sin espacios al inicio: "+nombre.TrimStart());

            Console.WriteLine("sin espacios al final: " + nombre.TrimEnd());
            Console.WriteLine("sin espacios en general: " + nombre.Trim());

        }

        private static void metodoPad()
        {
            // metodo que rellena espacios al inicio o al final de una cadena de caracteres para que sea de un tamaño especifico
            Console.WriteLine("\nMetodo pad");

            string nombreAlumno = "Alexis";

            string codigoAlumno = "123";

            // que la cadena tiene que medir 10 caracteres y los espacios faltantes los complete con '*'
            nombreAlumno = nombreAlumno.PadRight(10,'*');

            codigoAlumno = codigoAlumno.PadLeft(6,'0');

            Console.WriteLine("Nombre rellenado: "+nombreAlumno);
            Console.WriteLine("Codigo rellenado: "+codigoAlumno);
        }

        private static void metodoStartsWithEndsWith()
        {
            // funciones que permites ver si una cadena empieza o termina con una cadena de caracteres especifica 
            Console.WriteLine("\nMetodo StartsWithEndsWith");

            string archivo = "virus.dll";

            if (archivo.StartsWith("virus"))
            {
                Console.WriteLine("El archivo es un virus");
            }
            else { 
                Console.WriteLine("El archivo NO es un virus");

            }

            if (archivo.EndsWith(".dll")) {

                Console.WriteLine("Es un archivo dll");
            } else
            {
                Console.WriteLine("Es otro tipo de archivo");
            }
        }

        private static void metodoMayusculasMinusculas()
        {
            Console.WriteLine("\nMetodo ToLower y ToUpper");

            string nombre = "Alexis Villanueva";

            string nombreMayus = nombre.ToUpper();
            string nombreMinus = nombre.ToLower();

            Console.WriteLine("Nombre en mayusculas: "+nombreMayus);
            Console.WriteLine("Nombre en minusculas: " + nombreMinus);

            // si quisieramos hacerlo a mano, tendriamos que hacerlo con el codigo aski 

        }

        private static void metodoSubstring()
        {
            // el metodo substrig extrae una cadena de caracteres de una cadena de caracteres 
            Console.WriteLine("Método substring");

            string nombre = "Arely Sinai Munoz Tapia";

            string apellidos = nombre.Substring(12);

            Console.WriteLine("Mis apellidos son: "+apellidos);

            // cortar una cantidad de caracteres especifica 
            string nombre2 = "Arely Sinai Munoz Tapia";
            // que corte a partir del caracter num 12 y que cuente 5 caracteres posteriores
            string apellidoPaterno = nombre2.Substring(12,5);

            Console.WriteLine("Mi apellido paterno es: " + apellidoPaterno);

        }

        private static void metodoIndexOf()
        {
            // el metodo index of busca una cadena de caracteres y te dice en que posicion se encuentra 
            Console.WriteLine("\nMetodo Indez Of");

            string nombre = "Arely Munoz.\nClase: Programacion Orientada a Eventos";

            int posicion = nombre.IndexOf("Clase");

            Console.WriteLine("Posicion donde inicia la palabra Clase: "+posicion);

            // que busque la palabra clase a partir de la posicion 18 
            // en este caso, no va a encontrarla porque la palabra clase esta en la posicion 13, por ende va a retornarn un -1
            int posicion2 = nombre.IndexOf("Clase",18);

        }

        private static void metodoRecorridoString()
        {
            // esta funcion recorrera un string 
            Console.WriteLine("\nMetodo Recorrido String");

            string nombre = "Arely Munoz.\nClase: Programacion Orientada a Eventos";

            int contador = 0; //´para contar cuantos caracteres hay 

            foreach (char c in nombre)
            {

                // que no imprima el guion '-':
                if (c != '-') {
                    contador++;
                    // va a escribir una letra por renglon 
                    //Console.WriteLine(c); 

                    // para que eso no pase: 
                    Console.Write(c);

                }
               
            }

            Console.WriteLine("Cantidad de caracteres sin contar el '-': "+contador);
        }
    }
}
