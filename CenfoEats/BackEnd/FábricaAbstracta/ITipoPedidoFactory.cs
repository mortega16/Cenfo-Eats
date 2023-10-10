using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats
{
    // Fábrica abstracta para tipos de pedidos
    public interface ITipoPedidoFactory
    {
        ITipoPedido CrearPedido();
    }
}