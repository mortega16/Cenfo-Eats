using CenfoEats.BackEnd.Gestor;
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
    public partial class MenuOrdenPH : Form
    {
        public GestorRestaurante gestorPH;
        public MenuOrdenPH()
        {
            InitializeComponent();
            LlenarMenu();
        }

        private void MenuOrdenPH_Load(object sender, EventArgs e)
        {

        }
        private void btnOrdenarPH_Click(object sender, EventArgs e)
        {
            string tipoPedido = menuDespegableTipoPedidoPH.Text;

            GestorPedido gestorPedidos = new GestorPedido();
            ITipoPedido nuevoPedido = gestorPedidos.CrearPedido(tipoPedido);

            this.Hide();
            EstadoPedido estadoPedido = new EstadoPedido();
            estadoPedido.Show();


        }
        private void LlenarMenu()
        {
            
            GestorRestaurante gestorPH = new GestorRestaurante(300, 400);
          

            gestorPH.nuevoPizzaHut("Heredia, Santo Domingo", "20201010");
            gestorPH.nuevoPizzaHut("San Jose, Tibas", "20200101");
            gestorPH.nuevoPizzaHut("San Jose, Paseo Colon", "20201515");
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(0));
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(1));
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(2)); ;


        }
    }
}
