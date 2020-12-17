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
    public partial class frmMostExpensiveProduct : Form
    {
        public frmMostExpensiveProduct()
        {
            InitializeComponent();
        }

        private void dgdP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmMostExpensiveProduct_Load(object sender, EventArgs e)
        {
            DataSet dstPedido;
            dstPedido =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select description, price from product where price >= all(select price from product)");
            dgdP.ReadOnly = true;
            dgdP.DataSource = dstPedido;
            dgdP.DataMember = dstPedido.Tables[0].ToString();
        }
    }
}
