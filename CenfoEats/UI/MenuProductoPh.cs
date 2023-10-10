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
    public partial class MenuProductoPh : Form
    {
        public MenuProductoPh()
        {
            InitializeComponent();
        }

        private void Restaurantes_Click(object sender, EventArgs e)
        {

        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdernaPH_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuOrden menuOrden = new MenuOrden();
            menuOrden.Show();
        }
    }
}
