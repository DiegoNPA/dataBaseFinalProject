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
    public partial class frmAddOrder : Form
    {
        int id2;
        int price2;
        int stock2;
        string category2;
        string description2;
        int ci2;
        float sal;
        public frmAddOrder(int id, int price, int stock, string category, string description, int carnet, float saldo)
        {
            id2 = id;
            price2 = price;
            stock2 = stock;
            category2 = category;
            description2 = description;
            ci2 = carnet;
            sal = saldo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCant.Text);
            double disc = Convert.ToInt32(txtDisc.Text)*0.01;
            float d2 = (float)disc;
            float fp = cant * price2 - (d2*cant*price2);
            if(sal > fp)
            {
                float newBalance = sal - fp;
                string actualDate = DateTime.Now.ToString("MM/dd/yyyy");
                string expDate = DateTime.Now.AddDays(7).ToString("MM/dd/yyyy");
                StringBuilder strInsert = new StringBuilder();
                strInsert.AppendFormat("insert into orders(orderId,startDate,expDate,discount,quantity,status,finalPrice,address,clientId,productId) values({0},'{1}','{2}',{3},{4},'{5}',{6},'{7}',{8},{9});",
                txtOrderId.Text, actualDate, expDate, txtDisc.Text, txtCant.Text, "Pendiente", fp, txtDir.Text, ci2, id2);
                int cantMatsInsertadas =
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                StringBuilder strInsert1 = new StringBuilder();
                strInsert1.AppendFormat("update client set balance={0} where clientId=" + ci2,
                    newBalance);
                int cantMatsInsertadas1 =
                GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert1.ToString());
                MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
                " registro(s)", "Mensaje");
                Close();
            }
            else
            {
                MessageBox.Show("Saldo insuficiente, por favor agruegue saldo a su cuenta...");
                Close();
            }
        }
    }
}
