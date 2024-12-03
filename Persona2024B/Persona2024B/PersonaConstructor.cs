using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona2024B
{
    internal class PersonaConstructor
    {
        // propiedades (descripciones)
        string nombre;
        string color_ojos;
        string color_pelo;
        int edad;

        // constructor 
        public PersonaConstructor (string nombre, string color_ojos, string color_pelo, int edad)
        {
            this.nombre = nombre;
            this.color_ojos = color_ojos;
            this.color_pelo = color_pelo;
            this.edad = edad;
        }

        // metodos (acciones)
        public virtual void Caminar(int velocidad) // virtual le da permiso al hijo para sobreescribir un metodo y aplicar polimorfismo
        {
            Console.WriteLine("La persona camina a: " + velocidad + " km/h.");
        }

        public void Hablar()
        {
            Console.WriteLine("La persona esta hablando");
        }

        // GEtters y Setters
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetColor_ojos()
        {
            return color_ojos;
        }

        public void SetColor_ojos(string color_ojos)
        {
            this.color_ojos = color_ojos;
        }

        public string GetColor_pelo()
        {
            return color_pelo;
        }

        public void SetColor_pelo(string color_pelo)
        {
            this.color_pelo = color_pelo;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
