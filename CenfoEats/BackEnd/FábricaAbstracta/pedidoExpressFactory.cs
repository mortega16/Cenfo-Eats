using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fábrica Concreta

namespace CenfoEats.BackEnd.FábricaAbstracta
{
    internal class pedidoExpressFactory : ITipoPedidoFactory
    {
        public ITipoPedido CrearPedido()
        {
            return new pedidoExpress();
        }
    }
}

// Utilizar este código para crear el objeto

//ITipoPedidoFactory tipoPedidoFactory = new pedidoExpressFactory();
//ITipoPedido tipoPedido = tipoPedidoFactory.CrearPedido();
//Console.WriteLine(tipoPedido.ObtenerDescripcion()); // Pedido express

//Probando cambios 1.0