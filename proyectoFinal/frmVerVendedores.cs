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
    public partial class frmVerVendedores : Form
    {
        public frmVerVendedores()
        {
            InitializeComponent();
        }

        private void frmVerVendedores_Load(object sender, EventArgs e)
        {
            DataSet dstSeller;
            dstSeller =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from seller");
            dgdSeller.ReadOnly = true;
            dgdSeller.DataSource = dstSeller;
            dgdSeller.DataMember = dstSeller.Tables[0].ToString();
        }

        private void dgdSeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
