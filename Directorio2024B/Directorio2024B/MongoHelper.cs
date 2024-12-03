using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Windows.Forms;

namespace Directorio2024B
{
    public class MongoHelper
    {
        // cliente de mongo que se va a conectar a la base de datos
        public IMongoClient client { get; set; }

        // base de datos 
        public IMongoDatabase database { get; set; }

        public IMongoCollection<Persona> colPersona;

        // link del usuario a conectar - se cambia usuario, contraseña y nombre de la base ded datos en el link
        public string mongoURLConnection = "mongodb+srv://arely_s_25:Daniarely31@cluster0.3tfic.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        // nombre de la base de datos 
        public string mongoDataBase = "Directorio";

        public void connectToMongoService()
        {
            // poner un try porque si el usuario no tiene internet, va a tronar y mejor le mandamos un mensaje para que no truene
            try
            {
                // inicializar el objeto y asignarle la coneccion 
                client = new MongoClient(mongoURLConnection);

                // asignar la base de datos 
                database = client.GetDatabase(mongoDataBase);

                // va a la base de datos, intenta obtener una coleccion (tabla) y si no existe, la crea 
                colPersona = database.GetCollection<Persona>("Directorio");

            }
            catch (Exception ex)
            {
                // mensaje para nosotros para ver por que trono
                MessageBox.Show(ex.Message);

                // mensaje para el usuario
                MessageBox.Show("Revisa tu conexion a internet.");

            }

        }
    }
}
