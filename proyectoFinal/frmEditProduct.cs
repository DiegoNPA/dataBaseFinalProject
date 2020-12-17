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
    public partial class frmEditProduct : Form
    {
        int productId1;
        string description1;
        int stock1;
        int price1;
        string category1;
        public frmEditProduct(int productId, string description, int stock, int price, string category)
        {
            productId1 = productId;
            description1 = description;
            stock1 = stock;
            price1 = price;
            category1 = category;
            InitializeComponent();
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            txtId.Text = productId1.ToString();
            txtDesc.Text = description1;
            txtStock.Text = stock1.ToString();
            txtPrice.Text = price1.ToString();
            txtCat.Text = category1;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("update product set productId={0} where productId="+productId1, 
                txtId.Text);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            strInsert.AppendFormat("update product set description='{0}' where productId=" + productId1,
                txtDesc.Text);
            int cantMatsInsertadas1 =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            strInsert.AppendFormat("update product set stock={0} where productId=" + productId1,
                txtStock.Text);
            int cantMatsInsertadas2 =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            strInsert.AppendFormat("update product set price={0} where productId=" + productId1,
                txtPrice.Text);
            int cantMatsInsertadas3 =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            strInsert.AppendFormat("update product set category='{0}' where productId=" + productId1,
                txtCat.Text);
            int cantMatsInsertadas4 =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("delete from product where productId=" + productId1);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
