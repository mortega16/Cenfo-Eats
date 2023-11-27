using CenfoEats.BackEnd.Estado.abstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Estado.concreto
{
    public class EstadoPendiente : EstadoPedido
    {
        public override string mostrar()
        {
            return "Pendiente";
        }
    }
}
