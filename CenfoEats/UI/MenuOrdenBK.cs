using CenfoEats.BackEnd.Gestor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenfoEats.UI
{
    public partial class MenuOrdenBK : Form


    {

        public GestorRestaurante gestorBK;


        public MenuOrdenBK()
        {
            
            InitializeComponent();
            LlenarMenu();

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
        private void LlenarMenu()
        {
            GestorRestaurante gestorBK = new GestorRestaurante(100, 200);
            gestorBK.nuevoBurgerKing("Heredia, Santo Domingo", "22221010");
            gestorBK.nuevoBurgerKing("San Jose, Tibas", "22220101");
            gestorBK.nuevoBurgerKing("San Jose, Paseo Colon", "22221515");
            menuDespegableSedeRest.Items.Add(gestorBK.obtenerDatosBK(0));
            menuDespegableSedeRest.Items.Add(gestorBK.obtenerDatosBK(1));
            menuDespegableSedeRest.Items.Add(gestorBK.obtenerDatosBK(2));


        }

        private void Restaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            LlenarMenu();


        }

        private void menuDespegableTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
