using CenfoEats.BackEnd.Gestor;
using System;
using System.Windows.Forms;

namespace CenfoEats.UI
{
    public partial class MenuRepartidor : Form
    {
        public GestorRestaurante gestorPH;
        public GestorRestaurante gestorBK;

        public MenuRepartidor()
        {
            InitializeComponent();
            LlenarMenuPH();
            LlenarMenuBK();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuDespegableSedeRest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarMenuPH()
        {

            GestorRestaurante gestorPH = new GestorRestaurante(300, 400);


            gestorPH.nuevoPizzaHut("Heredia, Santo Domingo", "20201010");
            gestorPH.nuevoPizzaHut("San Jose, Tibas", "20200101");
            gestorPH.nuevoPizzaHut("San Jose, Paseo Colon", "20201515");
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(0));
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(1));
            menuDespegableSedeRestPH.Items.Add(gestorPH.obtenerDatosPH(2)); ;


        }
        private void LlenarMenuBK()
        {

            GestorRestaurante gestorBK = new GestorRestaurante(100, 200);

            gestorBK.nuevoBurgerKing("Heredia, Santo Domingo", "22221010");
            gestorBK.nuevoBurgerKing("San Jose, Tibas", "22220101");
            gestorBK.nuevoBurgerKing("San Jose, Paseo Colon", "22221515");
            menuDespegableSedeRestBK.Items.Add(gestorBK.obtenerDatosBK(0));
            menuDespegableSedeRestBK.Items.Add(gestorBK.obtenerDatosBK(1));
            menuDespegableSedeRestBK.Items.Add(gestorBK.obtenerDatosBK(2));


        }

        private void MenuRepartidor_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenarBK_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            MenuRepartidorPedido menuPedido = new MenuRepartidorPedido();
            menuPedido.Show();
        }

        private void menuDespegableSedeRestBK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
