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
    public partial class frmAccionesCliente : Form
    {
        int carnet;
        float saldo;
        public frmAccionesCliente(int ci)
        {
            InitializeComponent();
            carnet = ci;
        }

        private void frmAccionesCliente_Load(object sender, EventArgs e)
        {
            string consulta = "Select clientId,name,lastName,gender,balance from client where clientId = " + carnet.ToString();
            DataSet dstClient = new DataSet();
            dstClient = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            if (dstClient != null)
            {
                txtCi.Text = dstClient.Tables[0].Rows[0][0].ToString();
                txtName.Text = dstClient.Tables[0].Rows[0][1].ToString();
                txtLName.Text = dstClient.Tables[0].Rows[0][2].ToString();
                txtGender.Text = dstClient.Tables[0].Rows[0][3].ToString();
                txtBalance.Text = dstClient.Tables[0].Rows[0][4].ToString();
                saldo = (float)Convert.ToInt32(dstClient.Tables[0].Rows[0][4].ToString());
            }
            else
            {
                MessageBox.Show("No existe el ci ingreado...", "ERROR");
                Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListsByCi lists = new frmListsByCi(carnet);
            lists.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBankByCi bank = new frmBankByCi(carnet);
            bank.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrdersByCi ord = new frmOrdersByCi(carnet);
            ord.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBuyByCi buy = new frmBuyByCi(carnet, saldo);
            buy.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddMoney mon = new frmAddMoney(carnet);
            mon.ShowDialog();
        }
    }
}
