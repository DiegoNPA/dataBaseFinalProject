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
    public partial class frmVerClientes : Form
    {
        public frmVerClientes()
        {
            InitializeComponent();
        }

        private void frmVerClientes_Load(object sender, EventArgs e)
        {
            DataSet dstClient;
            dstClient =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from client");
            dgdClient.ReadOnly = true;
            dgdClient.DataSource = dstClient;
            dgdClient.DataMember = dstClient.Tables[0].ToString();
        }
    }
}
