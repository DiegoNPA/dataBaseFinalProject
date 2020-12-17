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
    public partial class frmChangeStatus : Form
    {
        int id1;
        public frmChangeStatus(int id)
        {
            id1 = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("update orders set status='{0}' where orderId=" + id1, "Entregado");
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("update orders set status='{0}' where orderId=" + id1, "Rechazado");
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            Close();
        }
    }
}
