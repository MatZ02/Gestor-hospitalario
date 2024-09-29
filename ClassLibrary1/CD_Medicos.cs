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
    }
}