using CenfoEats.BackEnd.Estado.abstracto;
using CenfoEats.BackEnd.Estado.concreto;
using CenfoEats.BackEnd.FábricaAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Gestor
{
    public class GestorEstado

    {
        private pedidoExpress objPedido;
        public GestorEstado() {
            objPedido = new pedidoExpress();
                }

        public string mostrarEstado()
        {
            return objPedido.mostrar();
        }
        public string cambiarEstado(int id)
        {
            EstadoPedido estado = null;
            switch (id)
            {
                case 1:
                    estado = new EstadoPendiente();
                    break;
                case 2:
                    estado = new EstadoEnCamino();
                    break;
                case 3:
                    estado = new EstadoEntregado();
                    break;

            }

            objPedido.setEstado(estado);
            return mostrarEstado(); 
        }
    }
}
