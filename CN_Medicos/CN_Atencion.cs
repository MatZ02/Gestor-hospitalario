using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.CD_Medicos;
using static ClassLibrary1.CD_Pacientes;

namespace CN_Medicos
{
    public class CN_Atencion
    {
        private CD_Atencion DatosAtencion = new CD_Atencion();

        public CD_Atencion.Atencion BuscarAtencion(int codigoAtencion)
        {
            return DatosAtencion.BuscarAtencion(codigoAtencion);
        }
        public CD_Atencion.Atencion IngresarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            DatosAtencion.IngresarAtencion(codigo, fecha, TipoConsulta, paciente, medico);
            CD_Atencion.Atencion atencion = new CD_Atencion.Atencion
            {
                Codigo = codigo,
                Fecha = fecha,
                TipoConsulta = TipoConsulta,
                Paciente = paciente,
                Medico = medico
            };
            return atencion;
        }
        public CD_Atencion.Atencion ActualizarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            DatosAtencion.ActualizarAtencion(codigo, fecha, TipoConsulta, paciente, medico);
            CD_Atencion.Atencion atencion = new CD_Atencion.Atencion
            {
                Codigo = codigo,
                Fecha = fecha,
                TipoConsulta = TipoConsulta,
                Paciente = paciente,
                Medico = medico
            };
            return atencion;
        }
        public CD_Atencion.Atencion EliminarAtencion(int codigo)
        {
            DatosAtencion.EliminarAtencion(codigo);
            CD_Atencion.Atencion atencion = new CD_Atencion.Atencion
            {
                Codigo = codigo
            };
            return atencion;
        }
    }
}
