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

        public void IngresarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            using (var conexion = new CD_Conexion().AbrirConexion())
            {
                try
                {
                    sql = "insert into Atencion values(" + codigo + "," + fecha + "," + TipoConsulta + "," + paciente + "," + medico + ")";
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
        public Atencion BuscarAtencion(int codigoAtencion)
        {
            using (var conexion = new CD_Conexion().AbrirConexion())
            {
                try
                {
                    sql = "SELECT * FROM Atencion WHERE CodigoAtencion = " + codigoAtencion + ";";
                    comando = new MySqlCommand(sql);
                    comando.Connection = Conexion.AbrirConexion();
                    lector = comando.ExecuteReader();
                    Atencion atencion = null;

                    if (lector.Read())
                    {
                        atencion = new Atencion
                        {
                            Codigo = lector.GetInt32("Codigo"),
                            Fecha = lector.GetDateTime("Fecha"),
                            TipoConsulta = lector.GetString("TipoConsulta"),
                            Paciente = new Pacientes
                            {
                                Codigo = lector.GetInt32("CodigoPaciente"),
                                Nombre = lector.GetString("Nombre"),
                                Apellido = lector.GetString("Apellido"),
                                Edad = lector.GetInt32("Edad"),
                                Genero = lector.GetString("Genero"),
                                Eps = lector.GetString("Eps")
                            },
                            Medico = new Medicos
                            {
                                Codigo = lector.GetInt32("CodigoMedico"),
                                Nombre = lector.GetString("Nombre"),
                                Apellido = lector.GetString("Apellido"),
                                Especialidad = lector.GetString("Especialidad"),
                                Consultorio = lector.GetString("Consultorio")
                            }
                        };
                    }
                    return atencion;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public void EliminarAtencion(int codigoAtencion)
        {
            using (var conexion = new CD_Conexion().AbrirConexion())
            {
                try
                {
                    sql = "delete from Atencion where CodigoAtencion = " + codigoAtencion;
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
