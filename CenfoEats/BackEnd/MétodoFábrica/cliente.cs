﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats
{
    public class cliente : IUsuario
    {
        public void RealizarAccion()
        {
            
        }
        public string ObtenerTipo()
        {
            return "cliente";
        }
    }
}
