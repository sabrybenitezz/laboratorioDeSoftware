using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Dominio;

using _02_Dominio.Repositorio;
using _03_Infraestructura.SchemasMongo;
using MongoDB;
using MongoDB.Driver;

/*namespace _03_Infraestructura
{
    public class AutomovilRepositorioMongoDB 
    {
        private IMongoCollection<AutomovilSchema> Conexion()
        {
            const String connectionUri = "mongodb://localhost:27017";
            const String dbName = "Automoviles";
            var Auto = new MongoAutomovil(connectionUri);
            var db = Auto.GetDatabase(dbName);
            var collection = db.GetCollection<AutomovilSchema>("Automovil");
            return collection;
        }
        public void EliminarAutomovil(Guid id)
        {
           var filter = Builders<Automovil>.filter.Eq(a=>a.Id new objectId(id))
               await collection.Delete(filter);
        }

        public void Grabar(Automovil automovil)
        {
            IMongoCollection<AutomovilSchema> AutomovilMongoDB = Conexion();
            AutomovilMongoDB.InsertOne(new AutomovilSchema { Patente = automovil.Patente(), Marca = automovil.Marca(), Modelo = automovil.Modelo(), Precio = automovil.Precio() });
        }
        

         

        public List<Automovil> ObtenerTodos()
        {
            List<Automovil> automoviles = new List<Automovil>();
            IMongoCollection<AutomovilSchema> AutomovilMongoDB = Conexion();
            var automovilEnDB = AutomovilMongoDB.Find(_ => true);

            foreach (var auto in automovilEnDB.ToList())
            {
                
                String patente = auto.Pantente;
                String marca= auto.Marca;
                String modelo = auto.Modelo;
                int precio = auto.Precio;
                Automovil automovil = new Automovil( patente, marca,modelo,precio);
               automoviles.Add(automovil);
            }
            return automoviles;
        }
    }
}



    }
}*/
