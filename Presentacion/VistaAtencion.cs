using ClassLibrary1;
using CN_Medicos;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VistaAtencion : Form
    {
        public VistaAtencion()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarAtenciones()
        {


        }

        private void BtnIngresarAtencion_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoAtencion = int.Parse(TxtCodigo.Text);
                DateTime fecha = FechaAtencion.Value;
                string tipoConsulta = TxtConsulta.Text;

                int codigoPaciente = int.Parse(TxtCodigoPaciente.Text);
                int codigoMedico = int.Parse(TxtCodigoMedico.Text);

                CN_Pacientes cnPacientes = new CN_Pacientes();
                CD_Pacientes.Pacientes paciente = cnPacientes.BuscarPaciente(codigoPaciente);

                if (paciente == null)
                {
                    MessageBox.Show("Paciente no encontrado.");
                    return;
                }

                CN_Medicos.CN_Medicos cnMedicos = new CN_Medicos.CN_Medicos();
                CD_Medicos.Medicos medico = cnMedicos.BuscarMedicoPorCodigo(codigoMedico);

                if (medico == null)
                {
                    MessageBox.Show("Médico no encontrado.");
                    return;
                }

                CN_Atencion cnAtencion = new CN_Atencion();
                cnAtencion.IngresarAtencion(codigoAtencion, fecha, tipoConsulta, paciente, medico);

                MessageBox.Show("Atención registrada correctamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que los códigos ingresados son válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la atención: " + ex.Message);
            }
        }

        private void BtnEliminarAtencion_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TxtCodigo.Text, out int codigoAtencion))
                {
                    CN_Atencion cnAtencion = new CN_Atencion();


                    var atencion = cnAtencion.BuscarAtencion(codigoAtencion);

                    if (atencion != null)
                    {

                        FechaAtencion.Value = atencion.Fecha;
                        TxtConsulta.Text = atencion.TipoConsulta;
                        TxtCodigoPaciente.Text = atencion.Paciente.Nombre;
                        TxtCodigoMedico.Text = atencion.Medico.Nombre;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna atención con ese código.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un código de atención válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar la atención: " + ex.Message);
            }
        }

        private void BtnActualizarAtencion_Click(object sender, EventArgs e)
        {

        }
    }
}

