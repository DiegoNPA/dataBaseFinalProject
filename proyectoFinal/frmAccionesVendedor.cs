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
    public partial class frmAccionesVendedor : Form
    {
        int id;
        public frmAccionesVendedor(int sellerId)
        {
            InitializeComponent();
            id = sellerId;
        }

        private void frmAccionesVendedor_Load(object sender, EventArgs e)
        {
            string consulta = "Select sellerId,name,description,type from seller where sellerId = " + id.ToString();
            DataSet dstSeller = new DataSet();
            dstSeller = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            if (dstSeller != null)
            {
                txtId.Text = dstSeller.Tables[0].Rows[0][0].ToString();
                txtName.Text = dstSeller.Tables[0].Rows[0][1].ToString();
                txtDesc.Text = dstSeller.Tables[0].Rows[0][2].ToString();
                txtType.Text = dstSeller.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("No existe el ci ingreado...", "ERROR");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdsById prods = new frmProdsById(id);
            prods.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddProd add = new frmAddProd(id);
            add.ShowDialog();
        }
    }
}
