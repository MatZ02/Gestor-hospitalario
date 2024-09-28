using MySql.Data.MySqlClient;
using System;
using static ClassLibrary1.CD_Medicos;
using static ClassLibrary1.CD_Pacientes;

namespace ClassLibrary1
{
    public class CD_Atencion
    {
        public class Atencion
        {
            public int Codigo { get; set; }
            public DateTime Fecha { get; set; }
            public string TipoConsulta { get; set; }
            public Pacientes Paciente { get; set; }
            public Medicos Medico { get; set; }
        }
        private CD_Conexion Conexion = new CD_Conexion();
        private string sql = "";
        private MySqlDataReader lector = null;
        private MySqlCommand comando = null;
        public void ActualizarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            using (var conexion = new CD_Conexion().AbrirConexion())
            {
                try
                {
                    sql = "update Medicos set codigo = " + codigo + ", fecha = " + fecha + ", Tipo_Consulta = " + TipoConsulta + ", CodigoPacientes = " + paciente + ", CodigoMedico = " + medico + "where Codigo = " + codigo;
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
}
