using MySql.Data.MySqlClient;
using System;

namespace ClassLibrary1
{
    public class CD_HistorialMedico
    {
        public class HistorialMedico
        {
            public int CodigoHistorial { get; set; }
            public int CodigoPaciente { get; set; }
            public CD_Pacientes.Pacientes Paciente { get; set; }
            public DateTime Fecha { get; set; }
            public string Diagnostico { get; set; }
            public int CodigoMedicamento { get; set; }
            public string Observaciones { get; set; }
        }

        private CD_Conexion Conexion = new CD_Conexion();
        private string sql = "";
        private MySqlDataReader lector = null;
        private MySqlCommand comando = null;

        public void IngresarHistorialMedico(int codigoHistorial, int codigoPaciente, DateTime fecha, string diagnostico, int codigoMedicamento, string observaciones)
        {
            try
            {
                sql = "INSERT INTO HistorialMedico (CodigoHistorial, CodigoPaciente, Fecha, Diagnostico, CodigoMedicamento, Observaciones) VALUES (" + codigoHistorial + "," + codigoPaciente + "," + fecha + "," + diagnostico + "," + codigoMedicamento + "," + observaciones + ")";
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

        public HistorialMedico BuscarHistorialMedico(int codigoHistorial)
        {
            try
            {
                sql = "SELECT * FROM HistorialMedico WHERE CodigoHistorial = " + codigoHistorial + ";";
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                lector = comando.ExecuteReader();
                HistorialMedico historial = null;

                if (lector.Read())
                {
                    historial = new HistorialMedico
                    {
                        CodigoHistorial = lector.GetInt32("CodigoHistorial"),
                        CodigoPaciente = lector.GetInt32("CodigoPaciente"),
                        Fecha = lector.GetDateTime("Fecha"),
                        Diagnostico = lector.GetString("Diagnostico"),
                        CodigoMedicamento = lector.GetInt32("CodigoMedicamento"),
                        Observaciones = lector.GetString("Observaciones")
                    };
                }
                return historial;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void ActualizarHistorialMedico(int codigoHistorial, int codigoPaciente, DateTime fecha, string diagnostico, int codigoMedicamento, string observaciones)
        {
            try
            {
                sql = "UPDATE HistorialMedico SET CodigoHistorial = " + codigoHistorial + ", CodigoPaciente = " + codigoPaciente + ", Fecha = " + fecha + ", Diagnostico = " + diagnostico + ", CodigoMedicamento = " + codigoMedicamento + ", Observaciones = " + observaciones + " WHERE CodigoHistorial = " + codigoHistorial;
                comando = new MySqlCommand(sql);
                comando.Connection = Conexion.AbrirConexion();
                comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {

            }
        }
        public void EliminarHistorialMedico(int codigoHistorial)
        {
            try
            {
                sql = "DELETE FROM HistorialMedico WHERE CodigoHistorial = " + codigoHistorial;
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
