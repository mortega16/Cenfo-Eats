using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Decorador
{
    public interface IProducto
    {
        string Descripcion();
        double Costo();
    }
}
