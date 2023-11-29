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
        private IUsuario usuarioActual;

        public GestorUsuario(UsuarioFactory factory)
        {
            this.factory = factory;
        }

        public IUsuario CrearUsuario(string tipoUsuario)
        {
            return factory.CrearUsuario(tipoUsuario);
        }

        // Agregar métodos para administrar usuarios si es necesario.

        public void EstablecerUsuarioActual(IUsuario usuario) // Marcar usuario para el proxy
        {
            usuarioActual = usuario;
        }
        public IUsuario ObtenerUsuarioActual() //  Marcar usuario para el proxy
        {
            return usuarioActual;
        }

    }
}
