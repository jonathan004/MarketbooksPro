using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketbooksPro
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }


        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string conn;
            SqlConnection cnn;
            conn = @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";
            cnn = new SqlConnection(conn);
            string query = "SELECT * FROM IniciarSeccion WHERE Usuario = '" + usuario.Text.Trim() + "'AND Contrasena = '" + clave.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            if(dta.Rows.Count==1)
            {
                MessageBox.Show("Bienvenido!");
                MenuPrincipal frm = new MenuPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contrasena no validos!");
            }

            cnn.Close();
            
       }
    }
}
