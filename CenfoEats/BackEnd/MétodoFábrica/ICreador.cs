﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.MétodoFábrica
{
    public interface ICreador
    {
        IUsuario CrearUsuario(string tipoUsuario);
    }
}
