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
    public partial class frmClientsWhoSpentMoreThan100 : Form
    {
        public frmClientsWhoSpentMoreThan100()
        {
            InitializeComponent();
        }

        private void frmClientsWhoSpentMoreThan100_Load(object sender, EventArgs e)
        {
            DataSet dstPedido;
            dstPedido =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select clientId from orders group by clientId having avg(finalPrice)>100");
            dgdC.ReadOnly = true;
            dgdC.DataSource = dstPedido;
            dgdC.DataMember = dstPedido.Tables[0].ToString();
        }
    }
}
