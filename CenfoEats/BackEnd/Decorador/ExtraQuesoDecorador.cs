using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Decorador
{
    public class ExtraQuesoDecorador:DecoradorProductoBase
    {
        public ExtraQuesoDecorador(IProducto producto) : base(producto) { }

        public override string Descripcion() => $"{base.Descripcion()}, Extra Queso";

        public override double Costo() => base.Costo() + 700.00;
    }
}
