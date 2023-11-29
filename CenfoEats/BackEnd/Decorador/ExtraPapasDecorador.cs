using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Decorador
{
    public class ExtraPapasDecorador:DecoradorProductoBase
    {
        public ExtraPapasDecorador(IProducto producto): base(producto) { }

        // Sobrescribe el método Descripcion para agregar "Extra Toppings"
        public override string Descripcion() => $"{base.Descripcion()}, Extra Papas";

        // Sobrescribe el método Costo para agregar el costo de "Extra Toppings"
        public override double Costo() => base.Costo() + 1000.00;
    }
}
