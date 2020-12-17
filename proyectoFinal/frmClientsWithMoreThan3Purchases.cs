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
    public partial class frmClientsWithMoreThan3Purchases : Form
    {
        public frmClientsWithMoreThan3Purchases()
        {
            InitializeComponent();
        }

        private void frmClientsWithMoreThan3Purchases_Load(object sender, EventArgs e)
        {
            DataSet dstPedido;
            dstPedido =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select clientId, max(finalPrice), count(*) as t from orders group by clientId");
            dgdC.ReadOnly = true;
            dgdC.DataSource = dstPedido;
            dgdC.DataMember = dstPedido.Tables[0].ToString();
        }
    }
}
