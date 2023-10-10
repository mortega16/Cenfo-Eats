using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CenfoEats
{
    public class BaseDeDatosSingleton
    {
        private static BaseDeDatosSingleton instancia;
        public SqlConnection conexion;  // Declarar la conexión como un campo de clase

        private BaseDeDatosSingleton()
        {
            // Configuración de la cadena de conexión a la base de datos SQL Server
            string cadenaConexion = "Data Source=DESKTOP-M8A9P8F;Initial Catalog=CenfoEats;Integrated Security=True";

            // Creación de la conexión a la base de datos
            conexion = new SqlConnection(cadenaConexion);  // Inicializar la conexión

            try
            {
                // Abre la conexión
                conexion.Open();
                // Otras configuraciones y operaciones de inicialización pueden ir aquí
            }
            catch (Exception ex)
            {
                // Manejo de errores, como registro de errores o lanzamiento de excepciones
                throw new Exception("Error al inicializar la conexión a la base de datos.", ex);
            }
        }

        public static BaseDeDatosSingleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new BaseDeDatosSingleton();
            }
            return instancia;
        }

        // Aquí se agregan métodos y propiedades para interactuar con la base de datos

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
