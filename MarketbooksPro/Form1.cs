using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketbooksPro
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            Personal prm = new Personal();
            prm.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
        }

        private void producto_Click(object sender, EventArgs e)
        {
            Productos prd = new Productos();
            prd.Show();
        }

        private void informe_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.Show();
        }

        private void ayuda1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\readme\Factura.pdf");
        }
    }
}
