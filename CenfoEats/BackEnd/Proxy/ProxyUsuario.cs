namespace CenfoEats
{
    public class ProxyUsuario : IUsuario
    {
        private IUsuario usuarioReal;

        public ProxyUsuario(IUsuario usuarioReal)
        {
            this.usuarioReal = usuarioReal;
        }

        public void RealizarAccion()
        {
            usuarioReal.RealizarAccion();
        }

    
        public bool PuedeAccederInfoCliente()
        {
            return usuarioReal.ObtenerTipo() == "repartidor";
        }

        public string ObtenerTipo()
        {
            return usuarioReal.ObtenerTipo();
        }
    }
}
