using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenfoEats.UI
{
    public partial class MenuOrden : Form
    {
        public MenuOrden()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarBK_Click(object sender, EventArgs e)
        {
            String mensaje = "Orden realizada exitosamente";
            MessageBox.Show(mensaje);

            string tipoPedido = menuDespegableTipoPedido.Text;

            if (tipoPedido == "Express")
            {
                ITipoPedidoFactory tipoPedidoFactory = new BackEnd.FábricaAbstracta.pedidoExpressFactory();
                ITipoPedido pedidoNuevo = tipoPedidoFactory.CrearPedido();
                Console.WriteLine(pedidoNuevo.ObtenerDescripcion());

            }
            else if (tipoPedido == "LLevar")
            {
                
                ITipoPedidoFactory tipoPedidoFactory = new BackEnd.FábricaAbstracta.pedidoParaLlevarFactory();
                ITipoPedido pedidoNuevo = tipoPedidoFactory.CrearPedido();
                Console.WriteLine(pedidoNuevo.ObtenerDescripcion());

            }

        }

        private void restaurante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuDespegableTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
