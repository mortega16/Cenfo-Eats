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
    public partial class MenuRepartidorInfoCliente : Form
    {
        public MenuRepartidorInfoCliente()
        {
            InitializeComponent();
        }

        private void btnInfoClienteAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRepartidorPedido infoPedido = new MenuRepartidorPedido();
            infoPedido.Show();
        }
    }
}
