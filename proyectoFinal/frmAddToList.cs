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
    public partial class frmAddToList : Form
    {
        int id2;
        int price2;
        int stock2;
        string category2;
        string description2;
        int ci2;
        public frmAddToList(int id, int price, int stock, string category, string description, int carnet)
        {
            id2 = id;
            price2 = price;
            stock2 = stock;
            category2 = category;
            description2 = description;
            ci2 = carnet;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("insert into list(listId,type,name,clientId,productId) values({0},'{1}','{2}',{3},{4});",
            txtId.Text, txtType.Text, txtName.Text, ci2, id2);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
                " registro(s)", "Mensaje");
            Close();
        }
    }
}
