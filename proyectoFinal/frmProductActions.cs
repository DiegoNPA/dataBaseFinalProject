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
    public partial class frmProductActions : Form
    {
        int ci;
        int id1;
        int price1;
        int stock1;
        string category1;
        string description1;
        float sal;
        public frmProductActions(int id, int price, int stock, string description, string category, int carnet, float saldo)
        {
            id1 = id;
            price1 = price;
            stock1 = stock;
            category1 = category;
            description1 = description;
            ci = carnet;
            sal = saldo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddOrder order = new frmAddOrder(id1, price1, stock1, category1, description1, ci, sal);
            order.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddToList list = new frmAddToList(id1, price1, stock1, category1, description1, ci);
            list.ShowDialog();
        }
    }
}
