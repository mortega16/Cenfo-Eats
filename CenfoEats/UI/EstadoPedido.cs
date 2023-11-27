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
    public partial class EstadoPedido : Form
    {
        public GestorEstado gestorEstado;
        private Timer timer;
        private int contador;

        public EstadoPedido()
        {
            
            InitializeComponent();
            contador = 1;
            timer = new Timer();
            timer.Interval = 10000; // 10000 milisegundos = 10 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
            //llenarLabel();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Se ejecutará cada 10 segundos
            llenarLabel();
        }

        private void Restaurantes_Click(object sender, EventArgs e)
        {

        }
        private void Salir_Click(object sender, EventArgs e)
        {
 
            this.Hide();
            MenuRestaurantes menuRestaurantes = new MenuRestaurantes();
            menuRestaurantes.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void llenarLabel()
        {
            if (contador == 1)
            {
                PendienteBar.BackColor= Color.Lime;
            }
            if (contador == 2)
            {
                EnCaminoBar.BackColor = Color.Lime;
            }
            if(contador == 3)
            {
                EntregadoBar.BackColor = Color.Lime;
            }
            GestorEstado estado = new GestorEstado();
            string valor = estado.cambiarEstado(contador);

            label1.Text = valor;

             
            if (contador<3)
            {
                contador++;
            }
            


        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
