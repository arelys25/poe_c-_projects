using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;

namespace Directorio2024B
{
    public class Persona
    {
        // ID
        [BsonId]
        public ObjectId Id { get; set; } // ObjectId es para que no solo tenga llaves int, sino de cualquier tipo

        [BsonElement("nombre")]


        // ATRIBUTOS DEL OBJETO
        public string nombre { get; set; }
        [BsonElement("apellido")]
        public string apellido { get; set; }
        [BsonElement("telefono")]
        public string telefono { get; set; }
        [BsonElement("correo")]
        public string correo { get; set; }

    }
}
