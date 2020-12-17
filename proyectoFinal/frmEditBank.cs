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
    public partial class frmEditBank : Form
    {
        int cardNumber1;
        string bankName1;
        public frmEditBank(int cardNumber, string bankName)
        {
            cardNumber1 = cardNumber;
            bankName1 = bankName;
            InitializeComponent();
        }

        private void frmEditBank_Load(object sender, EventArgs e)
        {
            txtBank.Text = bankName1;
            txtCard.Text = cardNumber1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("update bankAccount set cardNumber={0} where cardNumber=" + cardNumber1,
                txtCard.Text);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            strInsert.AppendFormat("update bankAccount set bankName='{0}' where cardNumber=" + cardNumber1,
                txtBank.Text);
            int cantMatsInsertadas1 =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("delete from bankAccount where cardNumber=" + cardNumber1);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
