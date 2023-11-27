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
        private static string Tipo = "Pedido para llevar";
        public string ObtenerDescripcion()
        {
            return Tipo;
        }
    }
}
