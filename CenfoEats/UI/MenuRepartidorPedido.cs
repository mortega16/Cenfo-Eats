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


namespace CenfoEats.UI
{
    public partial class MenuRepartidorPedido : Form
    {
        public MenuRepartidorPedido()
        {
            InitializeComponent();
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

        private void btnCliente_Click(String tipoUsuario,object sender, EventArgs e)
        {
            validar(tipoUsuario);

        }


        // Funcion para implementacion del proxy
        private void validar(String tipoUsuario) {
            if (tipoUsuario == "repartidor")
            {
                this.Hide();
                MenuRepartidorInfoCliente infoCliente = new MenuRepartidorInfoCliente();
                infoCliente.Show();
            }
            else
            {
                //Pantalla Error en caso de contar con el perfil de colaborador

                this.Hide();
                ErrorForm infoError = new ErrorForm();
                infoError.Show();
            }
        }

     

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
