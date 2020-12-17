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
    public partial class frmOrdersByCi : Form
    {
        int carnet;
        public frmOrdersByCi(int ci)
        {
            InitializeComponent();
            carnet = ci;
        }

        private void frmOrdersByCi_Load(object sender, EventArgs e)
        {
            DataSet dstOrder;
            dstOrder =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select description, O.* from orders O, product P where O.productId=P.productId and clientId=" + carnet.ToString());
            dgdOrder.ReadOnly = true;
            dgdOrder.DataSource = dstOrder;
            dgdOrder.DataMember = dstOrder.Tables[0].ToString();
        }

        private void dgdOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Convert.ToInt32(dgdOrder.Rows[index].Cells["orderId"].Value);
            frmChangeStatus change = new frmChangeStatus(id);
            change.ShowDialog();
        }
    }
}
