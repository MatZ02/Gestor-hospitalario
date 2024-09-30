using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class CD_Pacientes
    {
        public class Pacientes
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }
            public string Eps { get; set; }
        }


        private CD_Conexion Conexion = new CD_Conexion();
        private string sql = "";
        private MySqlDataReader lector = null;
        private MySqlCommand comando = null;

        public void IngresarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            try
            {
                sql = "INSERT INTO pacientes (CodigoPaciente, Nombre, Apellido, Edad, Genero, Eps) VALUES (@codigo, @nombre, @apellido, @edad, @genero, @eps)";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.Parameters.AddWithValue("@genero", genero);
                comando.Parameters.AddWithValue("@eps", eps);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar paciente: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public Pacientes BuscarPacientePorCodigo(int codigo)
        {
            Pacientes paciente = null;
            try
            {
                sql = "SELECT * FROM pacientes WHERE CodigoPaciente = @codigo";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.Parameters.AddWithValue("@codigo", codigo);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    paciente = new Pacientes
                    {
                        Codigo = reader.GetInt32("CodigoPaciente"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Edad = reader.GetInt32("Edad"),
                        Genero = reader.GetString("Genero"),
                        Eps = reader.GetString("Eps")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar paciente: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return paciente;
        }

        public void EliminarPacientes(int codigo)
        {
            try
            {
                MySqlConnection conexion = Conexion.AbrirConexion();
                string sql = "DELETE FROM Pacientes WHERE CodigoPaciente = @CodigoPaciente";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@CodigoPaciente", codigo);
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el paciente: " + ex.Message);
            }
        }
        public void ActualizarPacientes(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            try
            {
                MySqlConnection conexion = Conexion.AbrirConexion();

                string sql = "UPDATE pacientes SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Genero = @Genero, Eps = @Eps WHERE CodigoPaciente = @CodigoPaciente";

                MySqlCommand comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@CodigoPaciente", codigo);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Edad", edad);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Eps", eps);

                comando.ExecuteNonQuery();

                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el paciente: " + ex.Message);
            }
        }
        public List<Pacientes> ListarPacientes()
        {
            List<Pacientes> listaPacientes = new List<Pacientes>();
            try
            {
                sql = "SELECT * FROM pacientes";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Pacientes paciente = new Pacientes
                    {
                        Codigo = lector.GetInt32("CodigoPaciente"),
                        Nombre = lector.GetString("Nombre"),
                        Apellido = lector.GetString("Apellido"),
                        Edad = lector.GetInt32("Edad"),
                        Genero = lector.GetString("Genero"),
                        Eps = lector.GetString("Eps")
                    };
                    listaPacientes.Add(paciente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pacientes: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return listaPacientes;
        }
    }
}
