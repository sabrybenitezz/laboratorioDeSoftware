using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Infraestructura.SchemasMongo
{
    public class AutomovilSchema
    {
        
       
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
    }
}
