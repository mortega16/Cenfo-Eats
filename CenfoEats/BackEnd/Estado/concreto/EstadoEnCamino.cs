using CenfoEats.BackEnd.Estado.abstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Estado.concreto
{
    public class EstadoEnCamino:EstadoPedido
    {
       
        public override string mostrar()
        {
            return "En camino"; 
        }
    }
}
