using ClassLibrary1;
using CN_Medicos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class EliminarPaciente : Form
    {
        public EliminarPaciente()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCodigo.Text))
                {
                    int codigoPaciente = int.Parse(TxtCodigo.Text);

                    CN_Pacientes cnPacientes = new CN_Pacientes();

                    cnPacientes.EliminarPaciente(codigoPaciente);

                    MessageBox.Show("Paciente eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un código de paciente válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paciente: " + ex.Message);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Pacientes cnPacientes = new CN_Pacientes();

                List<CD_Pacientes.Pacientes> listaPacientes = cnPacientes.ListarPacientes();

                ListaPacientes.DataSource = listaPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message);
            }
        }
    }
}
