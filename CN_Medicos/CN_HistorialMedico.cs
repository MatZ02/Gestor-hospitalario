using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace CN_Medicos
{
    public class CN_HistorialMedico
    {
        private CD_HistorialMedico historialMedico = new CD_HistorialMedico();
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

        public CD_HistorialMedico.HistorialMedico IngresarHistorialMedico(int codigoHistorial, int codigoPaciente, DateTime fecha, string diagnostico, int codigoMedicamento, string observaciones, CD_HistorialMedico historial)
        {
            historialMedico.IngresarHistorialMedico(codigoHistorial, codigoPaciente, fecha, diagnostico, codigoMedicamento, observaciones);
            CD_HistorialMedico.HistorialMedico historialObj = new CD_HistorialMedico.HistorialMedico
            {
                CodigoHistorial = codigoHistorial,
                CodigoPaciente = codigoPaciente,
                Fecha = fecha,
                Diagnostico = diagnostico,
                CodigoMedicamento = codigoMedicamento,
                Observaciones = observaciones
            };
            return historialObj;
        }
        public CD_HistorialMedico.HistorialMedico BuscarHistorialMedico(int codigoHistorial)
        {
            CD_HistorialMedico.HistorialMedico historial = historialMedico.BuscarHistorialMedico(codigoHistorial);
            return historial;
        }
        public CD_HistorialMedico.HistorialMedico ModificarHistorialMedico(int codigoHistorial, int codigoPaciente, DateTime fecha, string diagnostico, int codigoMedicamento, string observaciones)
        {
            historialMedico.ActualizarHistorialMedico(codigoHistorial, codigoPaciente, fecha, diagnostico, codigoMedicamento, observaciones);
            CD_HistorialMedico.HistorialMedico historialObj = new CD_HistorialMedico.HistorialMedico
            {
                CodigoHistorial = codigoHistorial,
                CodigoPaciente = codigoPaciente,
                Fecha = fecha,
                Diagnostico = diagnostico,
                CodigoMedicamento = codigoMedicamento,
                Observaciones = observaciones
            };
            return historialObj;
        }
        public CD_HistorialMedico.HistorialMedico EliminarHistorialMedico(int codigoHistorial)
        {
            historialMedico.EliminarHistorialMedico(codigoHistorial);
            CD_HistorialMedico.HistorialMedico historialObj = new CD_HistorialMedico.HistorialMedico
            {
                CodigoHistorial = codigoHistorial
            };
            return historialObj;
        }
    }
}
