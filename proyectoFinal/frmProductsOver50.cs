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
    public partial class frmProductsOver50 : Form
    {
        public frmProductsOver50()
        {
            InitializeComponent();
        }

        private void frmProductsOver50_Load(object sender, EventArgs e)
        {
            DataSet dstPedido;
            dstPedido =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("exec ex1 50");
            dgdP.ReadOnly = true;
            dgdP.DataSource = dstPedido;
            dgdP.DataMember = dstPedido.Tables[0].ToString();
        }
    }
}
