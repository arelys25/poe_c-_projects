using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona2024B
{
    // se hereda con ':'
    internal class Hija : PersonaConstructor
    {
        // propiedades 
        string madre;
        string padre;

        // constructor
        // ': base' llama al constructor del padre y seleccionas los atributos a heredar
        public Hija(string nombre, string color_ojos, string color_pelo, int edad, string madre, string padre): base (nombre,color_ojos,color_pelo,edad) { 
            
            this.madre = madre;
            this.padre = padre;
        }

        // metodos 
        public void llorar() {
            Console.WriteLine("Es un bebe y llora...");
        }

        // metodo donde se aplicará polimorfismo (es heredado del padre) se una override y se escribe el metodo tal cual 
        public override void Caminar(int velocidad)
        {
            base.Caminar(velocidad); // usamos base para heredar lo que ya hace el metodo caminar de la clase padre y además va a hacer lo del metodo de la clase hijo
            Console.WriteLine("Aún no sabe caminar muy bien...");
        }

        // getters y setters
        public string GetMadre()
        {
            return madre;
        }

        public void SetMadre(string nombreMadre)
        {
            madre = nombreMadre;
        }

        public string GetPadre()
        {
            return padre;
        }

        public void SetPadre(string nombrePadre)
        {
            padre = nombrePadre;
        }

    }
}
