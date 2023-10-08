using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fábrica Concreta

namespace CenfoEats.BackEnd.FábricaAbstracta
{
    internal class pedidoParaLlevarFactory : ITipoPedidoFactory
    {
        public ITipoPedido CrearPedido()
        {
            return new pedidoParaLlevar();
        }
    }
}

// Utilizar este código para crear el objeto

//ITipoPedidoFactory tipoPedidoFactory = new pedidoParaLlevarFactory();
//ITipoPedido tipoPedido = tipoPedidoFactory.CrearPedido();
//Console.WriteLine(tipoPedido.ObtenerDescripcion()); // Pedido para llevar