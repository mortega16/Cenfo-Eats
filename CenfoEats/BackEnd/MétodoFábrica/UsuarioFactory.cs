using CenfoEats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats
{
    public class UsuarioFactory : BackEnd.MétodoFábrica.ICreador
    {
        public IUsuario CrearUsuario(string tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case "cliente":
                    return new cliente();
                case "repartidor":
                    return new repartidor();
                default:
                    throw new ArgumentException("Tipo de usuario no válido");
            }
        }
    }

}

// Otros Aspectos

//Para cuando necesitemos crear usuarios, usamos este código

//UsuarioFactory factory = new UsuarioFactory();
//IUsuario usuarioFinal = factory.CrearUsuario("cliente");
//IUsuario repartidor = factory.CrearUsuario("Repartidor");

//usuario1.RealizarAccion(); // Cliente realiza una acción
//usuario2.RealizarAccion(); // Repartidor realiza una acción

