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
    public partial class frmProdsById : Form
    {
        int id;
        public frmProdsById(int sellerId)
        {
            InitializeComponent();
            id = sellerId;
        }

        private void frmProdsById_Load(object sender, EventArgs e)
        {
            DataSet dstProds;
            dstProds =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from product where sellerId=" + id.ToString());
            dgdProds.ReadOnly = true;
            dgdProds.DataSource = dstProds;
            dgdProds.DataMember = dstProds.Tables[0].ToString();
        }

        private void dgdProds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Convert.ToInt32(dgdProds.Rows[index].Cells["productId"].Value);
            int price = Convert.ToInt32(dgdProds.Rows[index].Cells["price"].Value);
            int stock = Convert.ToInt32(dgdProds.Rows[index].Cells["stock"].Value);
            string description = dgdProds.Rows[index].Cells["description"].Value.ToString();
            string category = dgdProds.Rows[index].Cells["category"].Value.ToString();
            frmEditProduct edit = new frmEditProduct(id, description, stock, price, category);
            edit.ShowDialog();
        }
    }
}
