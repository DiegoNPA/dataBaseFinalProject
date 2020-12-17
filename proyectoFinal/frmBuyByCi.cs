using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace proyectoFinal
{
    public partial class frmBuyByCi : Form
    {
        int carnet;
        float sal;
        public frmBuyByCi(int ci, float saldo)
        {
            InitializeComponent();
            carnet = ci;
            sal = saldo;
        }

        private void frmBuyByCi_Load(object sender, EventArgs e)
        {
            DataSet dstProds;
            dstProds =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from product order by category");
            dgdProds.ReadOnly = true;
            dgdProds.DataSource = dstProds;
            dgdProds.DataMember = dstProds.Tables[0].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgdProds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Convert.ToInt32(dgdProds.Rows[index].Cells["productId"].Value);
            int price = Convert.ToInt32(dgdProds.Rows[index].Cells["price"].Value);
            int stock = Convert.ToInt32(dgdProds.Rows[index].Cells["stock"].Value);
            string description = dgdProds.Rows[index].Cells["description"].Value.ToString();
            string category = dgdProds.Rows[index].Cells["category"].Value.ToString();
            frmProductActions acts = new frmProductActions(id, price, stock, description, category, carnet, sal);
            acts.ShowDialog();
        }
    }
}
