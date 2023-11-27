using CenfoEats.BackEnd.FábricaAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Gestor
{
    public class GestorPedido
    {
        public ITipoPedido CrearPedido(string tipoPedido)
        {
            switch (tipoPedido)
            {
                case "Express":
                    return new pedidoExpress();
                case "Llevar":
                    return new pedidoParaLlevar();
                default:
                    throw new ArgumentException("Tipo de pedido no válido");
            }
        }
    }
}
