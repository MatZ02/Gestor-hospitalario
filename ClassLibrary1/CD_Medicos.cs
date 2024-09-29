using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class CD_Medicos
    {
        public class Medicos
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Especialidad { get; set; }
            public string Consultorio { get; set; }
        }


        private CD_Conexion Conexion = new CD_Conexion();
        private string sql = "";
        private MySqlDataReader lector = null;
        private MySqlCommand comando = null;

        public void IngresarMedicos(int codigo, string nombre, string apellido, string especialidad, string consultorio)
        {
            try
            {
                sql = "insert into medicos values(" + codigo + "," + nombre + "," + apellido + "," + especialidad + "," + consultorio + ")";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }
        public List<Medicos> ObtenerMedicos()
        {
            try
            {
                List<Medicos> listaMedicos = new List<Medicos>();
                sql = "SELECT * FROM Medicos";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Medicos medico = new Medicos
                    {
                        Codigo = lector.GetInt32("Codigo"),
                        Nombre = lector.GetString("Nombre"),
                        Apellido = lector.GetString("Apellido"),
                        Especialidad = lector.GetString("Especialidad"),
                        Consultorio = lector.GetString("Consultorio")
                    };

                    listaMedicos.Add(medico);
                }

                Conexion.CerrarConexion();
                return listaMedicos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void EliminarMedicos(int codigoMedico)
        {
            try
            {
                sql = "delete from Medicos where CodigoMedico = " + codigoMedico;
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }
        public void ActualizarMedicos(int codigo, string nombre, string apellido, string especialidad, string consultorio)
        {
            try
            {
                sql = "update Medicos set Nombre = " + nombre + ", Apellido = " + apellido + ", Especialidad = " + especialidad + ", Consultorio = " + consultorio + " where Codigo = " + codigo;
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