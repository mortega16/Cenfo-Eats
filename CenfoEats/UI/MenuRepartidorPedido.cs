﻿using CenfoEats.BackEnd.Gestor;
using CenfoEats.BackEnd.MétodoFábrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenfoEats.UI;


namespace CenfoEats.UI
{
    public partial class MenuRepartidorPedido : Form
    {
        private GestorUsuario gestorUsuarios;
        public MenuRepartidorPedido(GestorUsuario gestorUsuarios)
        {
            InitializeComponent();
            this.gestorUsuarios = gestorUsuarios;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Restaurantes_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarBK_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRepartidorInfoCliente infoCliente = new MenuRepartidorInfoCliente();
            infoCliente.Show();
        }


     

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            IUsuario usuarioActual = gestorUsuarios.ObtenerUsuarioActual();

            if (usuarioActual != null)
            {
                ProxyUsuario proxyUsuario = new ProxyUsuario(usuarioActual);

                if (proxyUsuario.PuedeAccederInfoCliente())
                {
                    // User is allowed to access customer information
                    this.Hide();
                    MenuRepartidorInfoCliente infoCliente = new MenuRepartidorInfoCliente();
                    infoCliente.Show();
                }
                else
                {
                    // User is not allowed to access customer information
                    MessageBox.Show("Error: You do not have permission to access customer information.");
                }
            }
        }
    }
}