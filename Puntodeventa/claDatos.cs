using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Puntodeventa
{
    class claDatos
    {
        SqlConnection conexion = new SqlConnection(@"server= DESKTOP-Q0PPMA2\JOSE; database=Puntodeventa; integrated security = true");
        public void Llenardgvnombre(DataGridView dgv, TextBox tb)

        {
            conexion.Open();
            string cadena = "Select Clientes.nom_cli AS Nombre,Clientes.ape_cli AS Apellido,Clientes.dir_cli AS Dirección,Clientes.tel_cli AS Teléfono,Clientes.email_cli AS Email,Clientes.estado_cli AS Estado from Clientes where nom_cli like '%" + tb.Text + "%'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter sdr = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgv.DataSource = dt;

            conexion.Close();          


        }

        public void Llenardgvcodigo(DataGridView dgv, TextBox tb)

        {
            conexion.Open();
            string cadena = "Select Clientes.nom_cli AS Nombre,Clientes.ape_cli AS Apellido,Clientes.dir_cli AS Dirección,Clientes.tel_cli AS Teléfono,Clientes.email_cli AS Email,Clientes.estado_cli AS Estado from Clientes where Clientes.id_cli like '%" + tb.Text + "%'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter sdr = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgv.DataSource = dt;

            conexion.Close();


        }
    }
}
