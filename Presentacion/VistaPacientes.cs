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
    public partial class VistaPacientes : Form
    {
        public VistaPacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarPacientes fmrIngresarPacientes = new IngresarPacientes();
            this.Hide();
            fmrIngresarPacientes.Show();
            fmrIngresarPacientes.FormClosed += (s, args) => this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarPacientes fmrActualizarPacientes = new ActualizarPacientes();
            this.Hide();
            fmrActualizarPacientes.Show();
            fmrActualizarPacientes.FormClosed += (s, args) => this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarPaciente fmrEliminarPaciente = new EliminarPaciente();
            this.Hide();
            fmrEliminarPaciente.Show();
            fmrEliminarPaciente.FormClosed += (s, args) => this.Show();
        }
    }
}
