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
    public partial class frmSelectSellerId : Form
    {
        public frmSelectSellerId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorCarnet = Convert.ToInt16(txtId.Text);
            frmAccionesVendedor fActions = new frmAccionesVendedor(valorCarnet);
            fActions.ShowDialog();
        }

        private void frmSelectSellerId_Load(object sender, EventArgs e)
        {

        }
    }
}
