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
    public partial class frmBankByCi : Form
    {
        int carnet;
        public frmBankByCi(int ci)
        {
            InitializeComponent();
            carnet = ci;
        }

        private void frmBankByCi_Load(object sender, EventArgs e)
        {
            DataSet dstBankAcc;
            dstBankAcc =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from bankAccount where clientId="+carnet.ToString());
            dgdBank.ReadOnly = true;
            dgdBank.DataSource = dstBankAcc;
            dgdBank.DataMember = dstBankAcc.Tables[0].ToString();
        }

        private void dgdBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int cardNumber = Convert.ToInt32(dgdBank.Rows[index].Cells["cardNumber"].Value);
            string bankName = dgdBank.Rows[index].Cells["bankName"].Value.ToString();
            frmEditBank edit = new frmEditBank(cardNumber, bankName);
            edit.ShowDialog();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("insert into bankAccount(cardNumber,bankName,clientId) values({0},'{1}',{2});",
            txtCard.Text, txtBank.Text, carnet);
            MessageBox.Show(strInsert.ToString());
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
