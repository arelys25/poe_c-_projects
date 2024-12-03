// crear una persona
using Persona2024B;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona1 = new Persona(); // se usa el constructor default 

        // utilizar metodos 
        persona1.Hablar();
        persona1.Caminar(5);
        Console.WriteLine();

        // utilizar getters y setters 
        persona1.SetNombre("Alexis Villanueva");
        persona1.SetColor_pelo("Negro");
        persona1.SetColor_ojos("Marrones claro");
        persona1.SetEdad(23);

        Console.WriteLine("La persona con nombre: " + persona1.GetNombre() + "\nTiene los ojos de color: " + persona1.GetColor_ojos() + "\nSu color de pelo: " + persona1.GetColor_pelo() + "\nSu edad: " + persona1.GetEdad());
        Console.WriteLine();

        PersonaConstructor persona2 = new PersonaConstructor("Arely Muñoz", "Marron claro", "Marron oscuro", 19);

        // asignar una nueva edad
        //persona2.SetEdad(20);

        Console.WriteLine("La persona con nombre: " + persona2.GetNombre() + "\nTiene los ojos de color: " + persona2.GetColor_ojos() + "\nSu color de pelo: " + persona2.GetColor_pelo() + "\nSu edad: " + persona2.GetEdad());
        Console.WriteLine();

        Hija persona3 = new Hija("Isabela Villanueva", "Marron claro", "Negro", 7, "Arely Muñoz", "Alexis Villanueva");
        Console.WriteLine("La persona con nombre: " + persona3.GetNombre() + "\nTiene los ojos de color: " + persona3.GetColor_ojos() + "\nSu color de pelo: " + persona3.GetColor_pelo() + "\nSu edad: " + persona3.GetEdad() + "\nSu madre es: " + persona3.GetMadre() + "\nSu padre es: " + persona3.GetPadre());
        Console.WriteLine();

        persona3.Caminar(1);
        persona3.Hablar();
        persona3.llorar();

        Console.WriteLine();
        Hija persona4 = new Hija("Carlos Villanueva", "Marron oscuro", "Marron claro", 9, "Arely Muñoz", "Alexis Villanueva");
        Console.WriteLine("La persona con nombre: " + persona4.GetNombre() + "\nTiene los ojos de color: " + persona4.GetColor_ojos() + "\nSu color de pelo: " + persona4.GetColor_pelo() + "\nSu edad: " + persona4.GetEdad() + "\nSu madre es: " + persona4.GetMadre() + "\nSu padre es: " + persona4.GetPadre());

    }
}