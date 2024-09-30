using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaPacientes frmPacientes = new VistaPacientes();
            this.Hide();
            frmPacientes.Show();
            frmPacientes.FormClosed += (s, args) => this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VistaAtencion frmAtencion = new VistaAtencion();
            this.Hide();
            frmAtencion.Show();
            frmAtencion.FormClosed += (s, args) => this.Show();
        }
    }
}
