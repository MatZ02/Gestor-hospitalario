using ClassLibrary1;
using System;
using static ClassLibrary1.CD_Medicos;
using static ClassLibrary1.CD_Pacientes;

namespace CN_Medicos
{
    public class CN_Atencion
    {
        private CD_Atencion DatosAtencion = new CD_Atencion();
        private CN_Facturacion facturacion = new CN_Facturacion();

        public CD_Atencion.Atencion BuscarAtencion(int codigoAtencion)
        {
            try
            {
                return DatosAtencion.BuscarAtencion(codigoAtencion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la atención: " + ex.Message);
            }
        }

        public CD_Atencion.Atencion IngresarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar la atención: " + ex.Message);
            }
        }

        public CD_Atencion.Atencion ActualizarAtencion(int codigo, DateTime fecha, string TipoConsulta, Pacientes paciente, Medicos medico)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la atención: " + ex.Message);
            }
        }

        public CD_Atencion.Atencion EliminarAtencion(int codigo)
        {
            try
            {
                DatosAtencion.EliminarAtencion(codigo);
                CD_Atencion.Atencion atencion = new CD_Atencion.Atencion
                {
                    Codigo = codigo
                };
                return atencion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la atención: " + ex.Message);
            }
        }

        public double CalcularFactura(int codigoMedico, int edadPaciente, string especialidadMedico, string metodoPago, double montoEntregado = 0)
        {
            try
            {
                double costoConsulta = facturacion.CalcularCostoConsulta(especialidadMedico, edadPaciente);

                double devuelta = facturacion.ProcesarPago(metodoPago, costoConsulta, montoEntregado);

                return devuelta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular la factura: " + ex.Message);
            }
        }
    }
}


