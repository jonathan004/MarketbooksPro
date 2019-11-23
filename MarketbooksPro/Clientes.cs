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
    public partial class Clientes : Form
    {
        string connectionString = @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";
        public Clientes()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            // Insertar Datos en la tabla Cliente
            String sqlCliente = "INSERT INTO Cliente (ClienteID, Cedula, Nombre, Apellidos, Telefono, Direccion, Sexo)"
                               + "VALUES ('" + idCliente.Text + "','" + CedulaCliente.Text + "','" + NombreCliente.Text + "','"
                               + ApellidoCliente.Text + "','" + TelefonoCliente.Text + "','" + DireccionCliente.Text + "','"
                               + SexoCliente.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlCliente, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cliente Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Ingresar Cliente");
            }
            finally
            {
                conn.Close();
            }
        }



        private void limpiar_Click(object sender, EventArgs e)
        {
            idCliente.Text = "";
            CedulaCliente.Text = "";
            NombreCliente.Text = "";
            ApellidoCliente.Text = "";
            SexoCliente.Text = "";
            DireccionCliente.Text = "";
            TelefonoCliente.Text = "";
        }

        private void buscarcliente_Click(object sender, EventArgs e)
        {
            string sqlBuscar = "SELECT * FROM Cliente WHERE ClienteID = " + BuscaCliente.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscar, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idCliente.Text = reader[0].ToString();
                    CedulaCliente.Text = reader[1].ToString();
                    NombreCliente.Text = reader[2].ToString();
                    ApellidoCliente.Text = reader[3].ToString();
                    SexoCliente.Text = reader[6].ToString();
                    DireccionCliente.Text = reader[5].ToString();
                    TelefonoCliente.Text = reader[4].ToString();

                }
                else
                {
                    MessageBox.Show("Ningun Registro Encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            BuscaCliente.Text = " ";
        }

        private void ActualizaCliente_Click(object sender, EventArgs e)
        {
            string SqlActualizar = "UPDATE Cliente SET Cedula = '" + CedulaCliente.Text + "', Nombre ='" + NombreCliente.Text +
                "',Apellidos='" + ApellidoCliente.Text + "',Telefono ='" + TelefonoCliente.Text + "',Direccion ='" + DireccionCliente.Text +
                "', Sexo ='" + SexoCliente.Text + "'WHERE ClienteID = "+idCliente.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActualizar, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cliente Actualizado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Actualizar Cliente");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
