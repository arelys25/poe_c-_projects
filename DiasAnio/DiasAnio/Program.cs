namespace DiasAnio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int dias, anio = 0, mes = 0, semana = 0, dia = 0, dias2;

            Console.WriteLine("Introduce el numero de dias:\n");
            dias = Convert.ToInt32(Console.ReadLine());
            dias2 = dias;

            // años 
            while (dias >= 365) {
                anio++;
                dias -= 365;
            }

            // meses 
            while (dias >= 30)
            {
                mes++;
                dias -= 30;
            }

            // semanas 
            while (dias >= 7)
            {
                semana++;
                dias -= 7;
            }

            // dias 
            while (dias >= 1)
            {
                dia++;
                dias -= 1;
            }

            Console.WriteLine();
            Console.WriteLine(dias2+" dias equivalen a:\n");
            Console.WriteLine(anio + " años");
            Console.WriteLine(mes + " meses");
            Console.WriteLine(semana + " semanas");
            Console.WriteLine(dia + " dias");

        }
    }
}
