using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    public class CD_Conexion
    {
        private MySqlConnection conexion;
        public CD_Conexion()
        {
            string server = "localhost";
            string database = "hospital";
            string uid = "root";
            string password = "";

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

