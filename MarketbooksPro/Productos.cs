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
    public partial class Productos : Form
    {
        string connectionString = @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";
        public Productos()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar3_Click(object sender, EventArgs e)
        {
            String sqlLibro = "INSERT INTO Libro (LibroID, Titulo, Descripcion, Ano)"
                              + "VALUES ('" + idLibro.Text + "','" + titulo.Text + "','" + Descripcion.Text + "','"
                              + AnioLibro.Text+"')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlLibro, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Libro Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al agregar un libro");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Actualiza1_Click(object sender, EventArgs e)
        {
            string SqlActualiza1 = "UPDATE Libro SET Titulo = '" + titulo.Text + "', Descripcion ='" + Descripcion.Text +
                "',Ano='" + AnioLibro.Text + "'WHERE LibroID = " + idLibro.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActualiza1, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Libro Actualizado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Actualizar");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buscar3_Click(object sender, EventArgs e)
        {
            string sqlBuscarLibro = "SELECT * FROM Libro WHERE LibroID = " + idLibro.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscarLibro, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    titulo.Text = reader[1].ToString();
                    Descripcion.Text = reader[2].ToString();
                    AnioLibro.Text = reader[3].ToString();
                }
                else
                {
                    MessageBox.Show("Ningun Libro Encontrado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al buscar libro");
            }
            finally
            {
                conn.Close();
            }
            idLibro.Text = " ";
        }

        private void agregar2_Click(object sender, EventArgs e)
        {
            String sqlEditorial = "INSERT INTO Editorial (EditorialID, Nombre, Direccion, Telefono, Descripcion)"
                              + "VALUES ('" + idEditorial.Text + "','" + NombreEditorial.Text + "','" + DireccionEditorial.Text + "','" + TelefonoEditorial.Text + "','"
                              + DescripcionEditorial.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlEditorial, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Editorial Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al agregar Editorial");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Actualiza2_Click(object sender, EventArgs e)
        {
            string SqlActualiza2 = "UPDATE Editorial SET Nombre = '" + NombreEditorial.Text + "', Direccion ='" + DireccionEditorial.Text +
               "', Telefono ='" + TelefonoEditorial.Text + "',Descripcion='" + DescripcionEditorial.Text + "'WHERE EditorialID = " + idEditorial.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActualiza2, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Editorial Actualizado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Actualizar Editorial");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buscar2_Click(object sender, EventArgs e)
        {
            string sqlBuscarEditorial = "SELECT * FROM Editorial WHERE EditorialID = " + idEditorial.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscarEditorial, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NombreEditorial.Text = reader[1].ToString();
                    DireccionEditorial.Text = reader[2].ToString();
                    TelefonoEditorial.Text = reader[3].ToString();
                    DescripcionEditorial.Text = reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("Ningun Editorial Encontrado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Buscar Editorial");
            }
            finally
            {
                conn.Close();
            }
            idEditorial.Text = " ";
        }

        private void agregar1_Click(object sender, EventArgs e)
        {
            String sqlAutor = "INSERT INTO Autor (AutorID, Nombre, Apellidos, Sexo, Biografia, FechaNacimiento)"
                              + "VALUES ('" + idAutor.Text + "','" + NombreAutor.Text + "','" + ApellidosAutor.Text + "','" + SexoAutor.Text + "','"
                              + BiografiaAutor.Text + "','" + FechaNacAutor.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlAutor, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Autor Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al agregar Autor");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Actualiza3_Click(object sender, EventArgs e)
        {
            string SqlActualiza3 = "UPDATE Autor SET Nombre = '" + NombreAutor.Text + "', Apellidos ='" + ApellidosAutor.Text + "', Sexo ='" + SexoAutor.Text +
               "', Biografia ='" + BiografiaAutor.Text + "',FechaNacimiento='" + FechaNacAutor.Text + "'WHERE AutorID = " + idAutor.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActualiza3, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Autor Actualizado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al actualizar Autor");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            string sqlBuscarAutor = "SELECT * FROM Autor WHERE AutorID = " + idAutor.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscarAutor, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NombreAutor.Text = reader[1].ToString();
                    ApellidosAutor.Text = reader[2].ToString();
                    SexoAutor.Text = reader[3].ToString();
                    BiografiaAutor.Text = reader[4].ToString();
                    FechaNacAutor.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Ningun Autor Encontrado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al buscar Autor");
            }
            finally
            {
                conn.Close();
            }
            idAutor.Text = " ";
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            String sqlBiblioteca = "INSERT INTO Biblioteca (BibliotecaID, CantidadDisponible, Descripcion, Proveedor, Editorial_Autor_LibroID, PrecioLista)"
                              + "VALUES ('" + idBiblioteca.Text + "','" + CantDisp.Text + "','" + DescrBiblioteca.Text + "','" + Proveedor.Text + "','"
                              + idProducto.Text + "','" + PrecioLista.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBiblioteca, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al guardar Registro en Biblioteca");
            }
            finally
            {
                conn.Close();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            idLibro.Text = "";
            titulo.Text = "";
            Descripcion.Text = "";
            AnioLibro.Text = "";
            idEditorial.Text = "";
            NombreEditorial.Text = "";
            DireccionEditorial.Text = "";
            TelefonoEditorial.Text = "";
            DescripcionEditorial.Text = "";
            idAutor.Text = "";
            NombreAutor.Text = "";
            ApellidosAutor.Text = "";
            SexoAutor.Text = "";
            BiografiaAutor.Text = "";
            FechaNacAutor.Text = "";
            idBiblioteca.Text = "";
            CantDisp.Text = "";
            Proveedor.Text = "";
            PrecioLista.Text = "";
            idProducto.Text = "";
            DescrBiblioteca.Text = "";
            busca.Text = "";
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string sqlBuscarProductoBiblioteca = "SELECT * FROM Biblioteca WHERE BibliotecaID = " + busca.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscarProductoBiblioteca, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idBiblioteca.Text = reader[0].ToString();
                    CantDisp.Text = reader[1].ToString();
                    Proveedor.Text = reader[3].ToString();
                    PrecioLista.Text = reader[5].ToString();
                    idProducto.Text = reader[4].ToString();
                    DescrBiblioteca.Text = reader[2].ToString();
                }
                else
                {
                    MessageBox.Show("Ningun Registro Encontrado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error en la busqueda");
            }
            finally
            {
                conn.Close();
            }
            idAutor.Text = " ";
        }
    }
}
