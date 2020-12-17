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
    public partial class frmSelectCi : Form
    {
        public frmSelectCi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorCarnet = Convert.ToInt16(txtCi.Text);
            frmAccionesCliente fActions = new frmAccionesCliente(valorCarnet);
            fActions.ShowDialog();
        }

        private void frmSelectCi_Load(object sender, EventArgs e)
        {

        }
    }
}
