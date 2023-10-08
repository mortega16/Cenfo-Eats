using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Producto Concreto

namespace CenfoEats.BackEnd.FábricaAbstracta
{
    internal class pedidoParaLlevar : ITipoPedido
    {
        public string ObtenerDescripcion()
        {
            return "Pedido estándar";
        }
    }
}
