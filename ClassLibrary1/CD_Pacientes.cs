using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.CryptoPro;
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
            public string Genero{ get; set; }
            public string Eps { get; set; }
        }


        private CD_Conexion Conexion = new CD_Conexion();
        private string sql = "";
        private MySqlDataReader lector = null;
        private MySqlCommand comando = null;

        public void IngresarPacientes(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            try
            {
                sql = "insert into pacientes values(" + codigo + "," + nombre + "," + apellido + "," + edad + "," + genero + "," + eps+")";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch(Exception ex)
            {
                
            }
        }
        public Pacientes BuscarPacientes(int codigoPaciente)
        {
            try
            {
                sql = "SELECT * FROM Pacientes WHERE CodigoPaciente = "+ codigoPaciente+";";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                lector = comando.ExecuteReader();
                Pacientes paciente = null;

                if (lector.Read())
                {
                    paciente = new Pacientes
                    {
                        Codigo = lector.GetInt32("Codigo"),
                        Nombre = lector.GetString("Nombre"),
                        Apellido = lector.GetString("Apellido"),
                        Edad = lector.GetInt32("Edad"),
                        Genero = lector.GetString("Genero"),
                        Eps = lector.GetString("Eps")
                    };
                }
                Conexion.CerrarConexion();
                return paciente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void EliminarPacientes(int codigoPaciente)
        {
            try
            {
                sql = "delete from Pacientes where CodigoPaciente = " + codigoPaciente;
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }
        public void ActualizarPacientes(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            try
            {
                sql = "update Pacientes set Nombre = " + nombre + ", Apellido = " + apellido + ", Edad = " + edad + ", Genero = " + genero + ", Eps = " + eps + " where Codigo = " + codigo;
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
