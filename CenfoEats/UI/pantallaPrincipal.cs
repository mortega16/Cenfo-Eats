//using CenfoEats.UI;
using CenfoEats.BackEnd.Gestor;
using CenfoEats.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CenfoEats
{
    public partial class pantallaPrincipal : Form
    {
        private GestorUsuario gestorUsuarios;
        public pantallaPrincipal()
        {
            InitializeComponent();
            // Crear una instancia del Factory y del Gestor
            var usuarioFactory = new UsuarioFactory();
            gestorUsuarios = new GestorUsuario(usuarioFactory);
        }


        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Abrir pantalla de inicio de sesión");//

            string nombre = txtBoxNombre.Text;
            string correo = txtBoxCorreo.Text;
            string telefono = txtBoxTelefono.Text;
            string tipo = txtBoxTipo.Text;


            BaseDeDatosSingleton baseDeDatos = BaseDeDatosSingleton.ObtenerInstancia();
            this.Hide();
            MenuRestaurantes menuRestaurantes = new MenuRestaurantes();
            MenuRepartidor menuRepartidor = new MenuRepartidor(gestorUsuarios);



            try
            {
                // Realizar la operación de registro de usuario
                // Esto puede implicar crear una consulta SQL o llamar a un procedimiento almacenado
                string consulta = "INSERT INTO usuarios (nombre, correo_electronico, telefono, tipo) " +
                                  "VALUES (@nombre, @correo, @telefono, @tipo)";

                using (SqlCommand comando = new SqlCommand(consulta, baseDeDatos.conexion))
                {
                    

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    if (tipo == "1")
                    {
                        comando.Parameters.AddWithValue("@tipo", "repartidor");
                        IUsuario nuevoUsuario = gestorUsuarios.CrearUsuario("repartidor");
                        gestorUsuarios.EstablecerUsuarioActual(nuevoUsuario); // linea para luego aplicar el proxy
                        nuevoUsuario.RealizarAccion();
                        menuRepartidor.Show();
                    }
                    if(tipo=="2")
                    {
                        comando.Parameters.AddWithValue("@tipo", "cliente");
                        IUsuario nuevoUsuario = gestorUsuarios.CrearUsuario("cliente");
                        gestorUsuarios.EstablecerUsuarioActual(nuevoUsuario);// linea para luego aplicar el proxy
                        nuevoUsuario.RealizarAccion();
                        menuRestaurantes.Show();
                    }

                    comando.ExecuteNonQuery();
                }

                // Cerrar la conexión cuando hayas terminado
                baseDeDatos.CerrarConexion();
            }
            catch (Exception ex)
            {
                // Manejo de errores, como registro de errores o lanzamiento de excepciones
                throw new Exception("Error al registrar un nuevo usuario.", ex);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Aquí deberías implementar la lógica para abrir la pantalla de inicio de sesión.
            // Puedes abrir una nueva ventana o un formulario de inicio de sesión.
            // Por ahora, simplemente mostraremos un mensaje de demostración.
            MessageBox.Show("Abrir pantalla Registro");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TextoBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
