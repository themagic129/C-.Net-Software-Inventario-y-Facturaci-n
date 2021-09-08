using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puntodeventa
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void AdministrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnclientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void Mnuclientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }
    }
}
