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
    public partial class MenuRestaurantes : Form
    {
        public MenuRestaurantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductoPh menuProductos = new MenuProductoPh();
            menuProductos.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TextoBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnBurgerKing_Click(object sender, EventArgs e)

        {
            this.Hide();
            MenuProductosBk menuProductosBk = new MenuProductosBk();
            menuProductosBk.Show();
        }

        private void MenuRestaurantes_Load(object sender, EventArgs e)
        {

        }
    }
}
