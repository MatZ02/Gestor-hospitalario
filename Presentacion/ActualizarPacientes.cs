using CN_Medicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ActualizarPacientes : Form
    {
        public ActualizarPacientes()
        {
            InitializeComponent();
        }
        private void CargarPacientes()
        {
            try
            {

                CN_Pacientes cnPacientes = new CN_Pacientes();
                var listaPacientes = cnPacientes.ListarPacientes(); 
                ListaPacientes.Rows.Clear();

                foreach (var paciente in listaPacientes)
                {
                    ListaPacientes.Rows.Add(paciente.Codigo, paciente.Nombre, paciente.Apellido, paciente.Edad, paciente.Genero, paciente.Eps);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }
        private void ActualizarPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void BtnActualizarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(TxtCodigo.Text);
                string nombre = TxtNombre.Text;
                string apellido = TxtApellido.Text;
                int edad = int.Parse(TxtEdad.Text);
                string genero = TxtGenero.Text;
                string eps = TxtEps.Text;

                CN_Pacientes cnPacientes = new CN_Pacientes();
                cnPacientes.ActualizarPaciente(codigo, nombre, apellido, edad, genero, eps);
                CargarPacientes();
                MessageBox.Show("Paciente actualizado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message);
            }
        }

        private void ListaPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (ListaPacientes.CurrentRow != null)
            {
                var fila = ListaPacientes.CurrentRow;

                TxtCodigo.Text = fila.Cells["CodigoPaciente"].Value.ToString();
                TxtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                TxtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                TxtEdad.Text = fila.Cells["Edad"].Value.ToString();
                TxtGenero.Text = fila.Cells["Genero"].Value.ToString();
                TxtEps.Text = fila.Cells["Eps"].Value.ToString();
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
