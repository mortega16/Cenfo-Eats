using CenfoEats.BackEnd.Estado.abstracto;
using CenfoEats.BackEnd.Estado.concreto;
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
        private EstadoPedido objEstadoPedido;
        private static string Tipo = "Pedido Express";
        public string ObtenerDescripcion()
        {
            return Tipo;
        }
        public void setEstado(EstadoPedido objEstadoPedido)
        {
            this.objEstadoPedido = objEstadoPedido;
        }
        public pedidoExpress()
        {
            setEstado(new EstadoEntregado());
        }
        
        public string mostrar()
        {
            return this.objEstadoPedido.mostrar();
        }
    }
}
