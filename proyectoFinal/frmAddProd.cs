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
    public partial class frmAddProd : Form
    {
        int sellerId;
        public frmAddProd(int id)
        {
            InitializeComponent();
            sellerId = id;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("insert into product(productId,description,stock,price,category,sellerId) values({0},'{1}',{2},{3},'{4}',{5});",
            txtId.Text, txtDesc.Text, txtStock.Text, txtPrice.Text, txtCat.Text, sellerId);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
