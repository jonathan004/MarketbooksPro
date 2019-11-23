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
    public partial class Personal : Form
    {
      string connectionString =  @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";

        public Personal()
        {       
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Insertar Datos en la tabla nomina

            String sqlNomina = "INSERT INTO Nomina (NominaID, SalarioBruto, Sneto, TipoNomina, Fecha, Rol, EmpleadoID)"
                               + "VALUES ('" + Nominaid.Text + "','" + Sbruto.Text + "','" + Sneto.Text + "','"
                               + Tpnomina.Text + "','" + FechaNomina.Text + "','" + RolNomina.Text + "','" + EmpleadoID2.Text+"')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlNomina, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Nomina Registrada");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Operacion Fallida! Revise los datos");
            }
            finally
            {
                conn.Close();
            }
        }

        private void GuardaEmpleado_Click(object sender, EventArgs e)
        {

            // Insertar Datos en la tabla empleado
            String sqlEmpleado = "INSERT INTO Empleado (EmpleadoID, Cedula, Nombre, Apellidos, EstadoCivil, Direccion, Sexo, FechaAlta, Telefono)"
                               + "VALUES ('" + EmpleadoID.Text + "','" + CedulaEmpleado.Text + "','" + NombreEmpleado.Text + "','"
                               + ApellidoEmpleado.Text + "','" + CivilEmpleado.Text + "','" + DireccionEmpleado.Text + "','"
                               + SexoEmpleado.Text + "','" + FechaIngresoEmpleado.Text + "','" + TelefonoEmpleado.Text + "')";

    
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlEmpleado, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Empleado Ingresado");
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Operacion Fallida! Revise los datos");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string sqlBuscar = "SELECT * FROM Nomina,Empleado WHERE Nomina.EmpleadoID = Empleado.EmpleadoID AND Nomina.NominaID = "+ buscarinf.Text;
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
                    Nominaid.Text = reader[0].ToString();
                    Sbruto.Text = reader[1].ToString();
                    Sneto.Text = reader[2].ToString();
                    Tpnomina.Text = reader[3].ToString();
                    FechaNomina.Text = reader[4].ToString();
                    RolNomina.Text = reader[5].ToString();
                    EmpleadoID.Text = reader[6].ToString();
                    CedulaEmpleado.Text = reader[8].ToString();
                    NombreEmpleado.Text = reader[9].ToString();
                    ApellidoEmpleado.Text = reader[10].ToString();
                    CivilEmpleado.Text = reader[11].ToString();
                    DireccionEmpleado.Text = reader[12].ToString();
                    SexoEmpleado.Text = reader[13].ToString();
                    FechaIngresoEmpleado.Text = reader[14].ToString();
                    TelefonoEmpleado.Text = reader[15].ToString();

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
            buscarinf.Text = " ";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Nominaid.Text = "";
            Sbruto.Text = "";
            Sneto.Text = "";
            Tpnomina.Text = "";
            RolNomina.Text = "";
            FechaNomina.Text = "";
            EmpleadoID.Text = "";
            NombreEmpleado.Text = "";
            ApellidoEmpleado.Text = "";
            SexoEmpleado.Text = "";
            FechaIngresoEmpleado.Text = "";
            CedulaEmpleado.Text = "";
            DireccionEmpleado.Text = "";
            CivilEmpleado.Text = "";
            TelefonoEmpleado.Text = "";
            EmpleadoID2.Text = "";

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string SqlEliminar = "DELETE FROM Nomina WHERE NominaID = " + buscarinf.Text;
            SqlConnection conn = new SqlConnection (connectionString);
            SqlCommand cmd = new SqlCommand(SqlEliminar, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Introduce el codigo de nomina a eliminar");
            }
            finally
            {
                conn.Close();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            string SqlActualizar = "UPDATE Nomina SET SalarioBruto = '" + Sbruto.Text + "', Sneto ='" + Sneto.Text +
                "',TipoNomina='" + Tpnomina.Text + "',Fecha ='" + FechaNomina.Text + "',Rol ='" + RolNomina.Text + 
                "', EmpleadoID ='" + EmpleadoID2.Text + "' WHERE NominaID = "+Nominaid.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActualizar, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i >= 0)
                {
                    MessageBox.Show("Registro Actualizado");
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

            
    }

    
}
