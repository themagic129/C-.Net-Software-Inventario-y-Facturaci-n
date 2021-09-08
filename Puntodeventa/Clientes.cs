using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Puntodeventa
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Mnuclientes_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Conexion a la bd para insertar nuevo cliente 
            SqlConnection conexion = new SqlConnection(@"server= DESKTOP-Q0PPMA2\JOSE; database=Puntodeventa; integrated security = true");
            conexion.Open();
            string cadena = "INSERT into Clientes(nom_cli,ape_cli,dir_cli,tel_cli,email_cli,estado_cli) VALUES (@nom_cli,@ape_cli,@dir_cli,@tel_cli,@email_cli,@estado_cli)";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@nom_cli",txtnomcli.Text);
            comando.Parameters.AddWithValue("@ape_cli",txtapellidocli.Text);
            comando.Parameters.AddWithValue("@dir_cli", txtdireccioncli.Text);
            comando.Parameters.AddWithValue("@tel_cli", txttelefonocli.Text);
            comando.Parameters.AddWithValue("@email_cli", txtemailcli.Text);
            comando.Parameters.AddWithValue("@estado_cli", cmbestado.SelectedItem);
            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente insertado correctamente");

            //Limpia todos los campos de texto
            txtnomcli.Text = "";
            txtapellidocli.Text = "";
            txtdireccioncli.Text = "";
            txttelefonocli.Text = "";
            txtemailcli.Text = "";
            txtnomcli.Focus();
            cmbestado.Text = "";





        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Btnnuevocli_Click(object sender, EventArgs e)
        {
            //Coloca activado a todos los textbox
            txtnomcli.Enabled = true;
            txtapellidocli.Enabled = true;
            txtdireccioncli.Enabled = true;
            txttelefonocli.Enabled = true;
            txtemailcli.Enabled = true;
            txtnomcli.Focus();
            cmbestado.Enabled = true;

            //Limpia todos los campos de texto
            txtnomcli.Text = "";
            txtapellidocli.Text = "";
            txtdireccioncli.Text = "";
            txttelefonocli.Text = "";
            txtemailcli.Text = "";
            txtnomcli.Focus();
            cmbestado.Text= "";

        }

        private void Btnbuscarcli_Click(object sender, EventArgs e)
        {

            if (cmbtipobuscar.Text == "Nombre")
            {
                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            }
            else if (cmbtipobuscar.Text == "Codigo")
            {

                claDatos llenarclicodigo = new claDatos();
                llenarclicodigo.Llenardgvcodigo(dgvclientes, txtbuscarcli);

            }
            else {

                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            };

        }

        private void Txtbuscarcli_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtbuscarcli_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cmbtipobuscar.Text == "Nombre")
            {
                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            }
            else if (cmbtipobuscar.Text == "Codigo")
            {

                claDatos llenarclicodigo = new claDatos();
                llenarclicodigo.Llenardgvcodigo(dgvclientes, txtbuscarcli);

            }
            else
            {

                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            };

        }

        private void Txtbuscarcli_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbtipobuscar.Text == "Nombre")
            {
                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            }
            else if (cmbtipobuscar.Text == "Codigo")
            {

                claDatos llenarclicodigo = new claDatos();
                llenarclicodigo.Llenardgvcodigo(dgvclientes, txtbuscarcli);

            }
            else
            {

                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            };
        }

        private void Txtbuscarcli_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmbtipobuscar.Text == "Nombre")
            {
                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            }
            else if (cmbtipobuscar.Text == "Codigo")
            {

                claDatos llenarclicodigo = new claDatos();
                llenarclicodigo.Llenardgvcodigo(dgvclientes, txtbuscarcli);

            }
            else
            {

                claDatos llenarclinombre = new claDatos();
                llenarclinombre.Llenardgvnombre(dgvclientes, txtbuscarcli);

            };
        }

        
    }
}
