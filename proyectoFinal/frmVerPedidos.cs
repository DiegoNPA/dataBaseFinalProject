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
    public partial class frmVerPedidos : Form
    {
        public frmVerPedidos()
        {
            InitializeComponent();
        }

        private void frmVerPedidos_Load(object sender, EventArgs e)
        {
            DataSet dstPedido;
            dstPedido =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from orders");
            dgdPedidos.ReadOnly = true;
            dgdPedidos.DataSource = dstPedido;
            dgdPedidos.DataMember = dstPedido.Tables[0].ToString();
        }
    }
}
