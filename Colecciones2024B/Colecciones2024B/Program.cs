// importacion de bibliotecas
using System.Collections;
using System.Collections.Generic;

namespace Colecciones2024B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila();
            Cola();
            TablaHash();
            ListaOrdenada();
        }

        private static void ListaOrdenada()
        {
            SortedList lista = new SortedList();

            lista.Add(25,"Arely Muñoz");
            lista.Add(15, "Alexis Villanueva");
            lista.Add(10, "Dania Muñoz");
            lista.Add(31, "Ashly Muñoz");
            lista.Add(18, "Bere Tapia");
            lista.Add(11, "Martin Tapia");
            lista.Add(13, "Leticia Gutiérrez");

            Console.WriteLine("Los elementos son: ");
            foreach(object llave in lista.Keys)
            {
                Console.WriteLine("Llave: " + llave + " | Valor: " + lista[llave]);

            }

            Console.WriteLine();
            lista.Remove(25);
            Console.WriteLine("Los elementos actualizados son: ");
            foreach (object llave in lista.Keys)
            {
                Console.WriteLine("Llave: " + llave + " | Valor: " + lista[llave]);

            }

            Console.WriteLine();
        }

        private static void TablaHash()
        {
            // ceracion de la tabla hash 
            Hashtable hashtable = new Hashtable();

            // agregar un elemento | llave + valor
            hashtable.Add("001","C#");
            hashtable.Add("002", "Java");
            hashtable.Add("003", "Python");

            Console.WriteLine("El tamaño de la tabla es: "+hashtable.Count);
            Console.WriteLine("Los elementos son:");

            // .Keys regresa todas las llaves (solo llaves, no su valor)
            foreach (string llave in hashtable.Keys)
            {
                //Console.WriteLine(llave);
                Console.WriteLine("Llave: "+llave +" | Valor: "+ hashtable[llave]);
            }


            Console.WriteLine();


        }


        private static void Cola()
        {
            // crear la cola
            Queue cola = new Queue();

            // agregar elementos 
            cola.Enqueue(25);
            cola.Enqueue(15);
            cola.Enqueue(27);

            Console.WriteLine("Tamaño de la cola: "+ cola.Count);

            Console.WriteLine("Los elementos son: ");

            while (cola.Count > 0) {
                Console.WriteLine(cola.Dequeue());
            }

            Console.WriteLine("Tamaño de la cola: " + cola.Count);
            Console.WriteLine();

        }

        private static void Pila()
        {
            // crear la pila
            Stack pila = new Stack();

            // push - agegar elemento
            pila.Push(25);
            pila.Push(15);
            pila.Push(27);
            Console.WriteLine("Tamaño de la pila: " + pila.Count);

            Console.WriteLine("Los elementos de la pila son: ");

            while (pila.Count > 0)
            { 
                Console.WriteLine(pila.Pop()); // que saque el elemento, lo muestre  y lo remueva (es lo que hace Pop)
            }
            Console.WriteLine("Tamaño de la pila: "+pila.Count);
            Console.WriteLine();


        }
    }
}
