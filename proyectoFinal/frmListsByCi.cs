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
    public partial class frmListsByCi : Form
    {
        int carnet;
        int ind;
        public frmListsByCi(int ci)
        {
            InitializeComponent();
            carnet = ci;
        }

        private void frmListsByCi_Load(object sender, EventArgs e)
        {
            DataSet dstList;
            dstList =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select listId, type,name,L.productId, description from list L, product P where L.productId=P.productId and clientId=" + carnet.ToString());
            dgdList.ReadOnly = true;
            dgdList.DataSource = dstList;
            dgdList.DataMember = dstList.Tables[0].ToString();
        }

        private void dgdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int listId = Convert.ToInt32(dgdList.Rows[index].Cells["listId"].Value);
            ind = listId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("delete from list where listId=" + ind);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
