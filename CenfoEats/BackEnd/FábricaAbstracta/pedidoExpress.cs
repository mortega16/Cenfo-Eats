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
        private static string Tipo = "Pedido Express";
        public string ObtenerDescripcion()
        {
            return Tipo;
        }
    }
}
