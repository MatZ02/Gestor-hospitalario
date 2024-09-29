using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    public class CD_Conexion
    {
        private MySqlConnection conexion;
        public CD_Conexion()
        {
            string server = "localhost"; // Dirección del servidor
            string database = "hospital"; // Nombre de la base de datos
            string uid = "root"; // Nombre de usuario, por defecto es 'root' en XAMPP
            string password = ""; // Contraseña, por defecto está vacía en XAMPP

            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";
            conexion = new MySqlConnection(connectionString);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}

