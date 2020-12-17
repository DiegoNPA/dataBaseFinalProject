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
    public partial class frmVerCuentas : Form
    {
        public frmVerCuentas()
        {
            InitializeComponent();
        }

        private void frmVerCuentas_Load(object sender, EventArgs e)
        {
            DataSet dstBankAcc;
            dstBankAcc =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from bankAccount");
            dgdBank.ReadOnly = true;
            dgdBank.DataSource = dstBankAcc;
            dgdBank.DataMember = dstBankAcc.Tables[0].ToString();
        }
    }
}
