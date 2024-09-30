using CN_Medicos;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class IngresarPacientes : Form
    {
        public IngresarPacientes()
        {
            InitializeComponent();
        }

        private void BtnIngresarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                    string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                    string.IsNullOrWhiteSpace(TxtEdad.Text) ||
                    string.IsNullOrWhiteSpace(TxtGenero.Text) ||
                    string.IsNullOrWhiteSpace(TxtEps.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TxtEdad.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingresa una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TxtCodigo.Text, out int codigoPaciente))
            {
                MessageBox.Show("Por favor, ingresa un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();
            string genero = TxtGenero.Text.Trim();
            string eps = TxtEps.Text.Trim();

            try
            {
                CN_Pacientes cnPacientes = new CN_Pacientes();
                if (cnPacientes.BuscarPaciente(codigoPaciente) != null)
                {
                    MessageBox.Show("El paciente con este código ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cnPacientes.IngresarPaciente(codigoPaciente, nombre, apellido, edad, genero, eps);

                MessageBox.Show("Paciente ingresado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtEdad.Clear();
            TxtGenero.Clear();
            TxtEps.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
