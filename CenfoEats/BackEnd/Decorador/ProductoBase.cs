using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Decorador
{
    public class ProductoBase : IProducto
    {
        public double Costo()
        {
            return 10.00;
        }
      
        public string Descripcion()
        {
            return "Producto base";
        }
    }
}
