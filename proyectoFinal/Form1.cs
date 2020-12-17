using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerVendedores sellers = new frmVerVendedores();
            sellers.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerClientes clients = new frmVerClientes();
            clients.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVerPedidos orders = new frmVerPedidos();
            orders.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVerCuentas accs = new frmVerCuentas();
            accs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVerProductos prods = new frmVerProductos();
            prods.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmVerListas list = new frmVerListas();
            list.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSeller addSeller = new frmAddSeller();
            addSeller.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient addCli = new frmAddClient();
            addCli.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSelectCi acts = new frmSelectCi();
            acts.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSelectSellerId sell = new frmSelectSellerId();
            sell.ShowDialog();
        }

        private void productosSobre50DePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsOver50 ov = new frmProductsOver50();
            ov.ShowDialog();
        }

        private void productoMasCaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostExpensiveProduct p = new frmMostExpensiveProduct();
            p.ShowDialog();
        }

        private void clientesQueHayanCompradoMasDe3ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientsWithMoreThan3Purchases c3 = new frmClientsWithMoreThan3Purchases();
            c3.ShowDialog();
        }

        private void clientesQueGastaronEnPromedioMasDe100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientsWhoSpentMoreThan100 m1 = new frmClientsWhoSpentMoreThan100();
            m1.ShowDialog();
        }
    }
}
