using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    public class CD_Conexion
    {
        private MySqlConnection BaseDatos = new MySqlConnection("Database = medicos_bd; Data Source = Localhost; User Id = root; password ='';");


        //abrir conexion
        public MySqlConnection AbrirConexion()
        {
            if (BaseDatos.State == System.Data.ConnectionState.Closed)
                BaseDatos.Open();
            return BaseDatos;
        }

        public MySqlConnection CerrarConexion()
        {
            if (BaseDatos.State == System.Data.ConnectionState.Open)
                BaseDatos.Close();
            return BaseDatos;
        }



    }
}

