using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Producto Concreto

namespace CenfoEats.BackEnd.FábricaAbstracta
{
    public class pedidoExpress : ITipoPedido
    {
        public string ObtenerDescripcion()
        {
            return "Pedido express";
        }
    }
}
