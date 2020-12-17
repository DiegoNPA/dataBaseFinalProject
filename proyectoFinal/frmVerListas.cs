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
    public partial class frmVerListas : Form
    {
        public frmVerListas()
        {
            InitializeComponent();
        }

        private void frmVerListas_Load(object sender, EventArgs e)
        {
            DataSet dstList;
            dstList =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from list");
            dgdList.ReadOnly = true;
            dgdList.DataSource = dstList;
            dgdList.DataMember = dstList.Tables[0].ToString();
        }
    }
}
