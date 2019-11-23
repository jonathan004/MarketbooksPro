using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Reflection;



namespace MarketbooksPro
{
    public partial class Ventas : Form

    {
        int cantidad = 0;
        int precio = 0;
        double itebis = 0.0;
        double total = 0.0;
        double totalneto = 0.0;

        string connectionString = @"Data Source=DESKTOP-J5VCRFS;Initial Catalog=MarketbooksPro;Integrated Security=True";

        SqlDataAdapter adapter = null;
        public Ventas()
        {
            InitializeComponent();
            //this.BindDataGridView();
           
            this.VerDatos("SELECT * FROM Factura");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Biblioteca br = new Biblioteca();
            br.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {

            cantidad = Int32.Parse(CantDisponible.Text);
            precio = Int32.Parse(PrecioLibro.Text);

            total = cantidad * precio;
            itebis = cantidad * precio * 0.18;
            totalneto = total + itebis;

            String sqlVenta = "INSERT INTO Factura (CodigoFactura, ClienteID, EmpleadoID, BibliotecaID, Cantidad, Fecha, TotalNeto, TotalBruto, Estado, Descripcion)"
                              + "VALUES ('" + codigoventa.Text + "','" + idCliente.Text + "','" + CodigoEmpleado.Text + "','" + idBiblioteca.Text + "','" + CantDisponible.Text + "','"
                              + fecha.Text + "','" + totalneto.ToString() + "','" + total.ToString() + "','" + Estado.Text + "','" + Descripcion.Text + "')";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlVenta, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro Ingresado");

                VerDatos(adapter.SelectCommand.CommandText);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();

            }
            Total1.Text = total.ToString();
            Total2.Text = itebis.ToString();
            Total3.Text = totalneto.ToString();

            

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            idCliente.Text = "";
            CodigoEmpleado.Text = "";
            fecha.Text = "";
            codigoventa.Text = "";
            Estado.Text = "";
            Descripcion.Text = "";
            idBiblioteca.Text = "";
            CantDisponible.Text = "";
            PrecioLibro.Text = "";
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string SqlEliminar = "DELETE FROM Factura WHERE CodigoFactura = " + codigoventa.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlEliminar, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro Eliminado");

                }
                VerDatos(adapter.SelectCommand.CommandText);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error al Eliminar Factura");
            }
            finally
            {
                conn.Close();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            cantidad = Int32.Parse(CantDisponible.Text);
            precio = Int32.Parse(PrecioLibro.Text);

            itebis = cantidad * precio * 0.18;
            total = cantidad * precio;
            totalneto = total + itebis;

            string SqlActFact = "UPDATE Factura SET ClienteID = '" + idCliente.Text + "', EmpleadoID ='" + CodigoEmpleado.Text +
               "', BibliotecaID ='" + idBiblioteca.Text + "', Cantidad='" + CantDisponible.Text + "', Fecha='" + fecha.Text + 
               "', TotalNeto='" + totalneto.ToString() + "', TotalBruto='" + total.ToString() + "', Estado='" + Estado.Text + 
               "', Descripcion='" + Descripcion.Text + "'WHERE BibliotecaID = " + idBiblioteca.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SqlActFact, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Pedido Actualizado");
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
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
          //  VerDatos();
            

        }

        public void VerDatos(string comando)
        {
            string sqlBuscaFact = comando;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlBuscaFact, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                 adapter = new SqlDataAdapter(sqlBuscaFact, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);
                
              /*  table.Columns.AddRange(new DataColumn[10] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Cliente", typeof(int)),
                new DataColumn("Empleado",typeof(int)),
                new DataColumn("IdBiblioteca", typeof(int)),
                new DataColumn("Cantidades", typeof(int)),
                new DataColumn("Fechas",typeof(string)),
                new DataColumn("Total_Neto", typeof(string)),
                new DataColumn("Total_Bruto", typeof(double)),
                new DataColumn("Estados",typeof(string)),
                new DataColumn("Descripcion Articulo", typeof(string)),
                });*/
              
                this.Visual.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                conn.Close();
            }
           
        }

        private void imprime_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Visual.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Visual.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Visual.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    try
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: "+ex);
                    }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

    

    }
}
