using System;
namespace CN_Medicos
{
    public class CN_Facturacion
    {
        public double CalcularCostoConsulta(string especialidadMedico, int edadPaciente)
        {
            try
            {
                double costoConsulta;

                if (especialidadMedico.ToLower() == "general")
                {
                    costoConsulta = 25000;
                }
                else
                {
                    costoConsulta = 80000;
                }

                if (edadPaciente < 5)
                {
                    costoConsulta -= costoConsulta * 0.10;
                }
                else if (edadPaciente > 60)
                {
                    costoConsulta -= costoConsulta * 0.20;
                }

                return costoConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el costo de la consulta: " + ex.Message);
            }
        }

        public double ProcesarPago(string metodoPago, double costoConsulta, double montoEntregado)
        {
            try
            {
                double devuelta = 0;

                if (metodoPago.ToLower() == "efectivo")
                {
                    if (montoEntregado >= costoConsulta)
                    {
                        devuelta = montoEntregado - costoConsulta;
                    }
                    else
                    {
                        throw new Exception("Monto entregado insuficiente.");
                    }
                }
                else if (metodoPago.ToLower() == "tarjeta débito" || metodoPago.ToLower() == "tarjeta crédito")
                {
                    devuelta = 0;
                }
                else
                {
                    throw new Exception("Método de pago no válido.");
                }

                return devuelta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar el pago: " + ex.Message);
            }
        }
    }
}

