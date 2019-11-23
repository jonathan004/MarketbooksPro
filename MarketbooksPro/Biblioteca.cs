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
    public partial class Biblioteca : Form
    {
        string connectionString = @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string sqlBuscaLibro = "SELECT * FROM Libro WHERE LibroID = " + idLibro.Text; ;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscaLibro, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlBuscaLibro, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                Visual2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                conn.Close();
            }
        }
    }
}
