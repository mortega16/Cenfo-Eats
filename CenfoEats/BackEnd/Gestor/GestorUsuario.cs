using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Gestor
{
    public class GestorUsuario
    {
        private UsuarioFactory factory;

        public GestorUsuario(UsuarioFactory factory)
        {
            this.factory = factory;
        }

        public IUsuario CrearUsuario(string tipoUsuario)
        {
            return factory.CrearUsuario(tipoUsuario);
        }

        // Agregar métodos para administrar usuarios si es necesario.
    }
}
