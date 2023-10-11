using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats
{
    public abstract class RestaurantePrototype
    {

        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public  string infoRestaurante()
        {
            return $"{Nombre}  ,{Direccion} , {Telefono} "; 
        }


        public abstract RestaurantePrototype Clone();
    }
}
