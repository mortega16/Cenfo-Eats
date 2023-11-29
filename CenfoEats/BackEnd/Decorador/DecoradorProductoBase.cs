using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Decorador
{
    public class DecoradorProductoBase:IDecoradorProducto
    {
        protected IProducto producto;

        public DecoradorProductoBase(IProducto producto)
        {
            this.producto = producto;
        }
        public virtual string Descripcion() => producto.Descripcion();
        public virtual double Costo() => producto.Costo();
    }
}

