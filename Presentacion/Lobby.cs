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
    }
}
