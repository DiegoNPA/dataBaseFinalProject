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
    public partial class frmVerProductos : Form
    {
        public frmVerProductos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            DataSet dstProds;
            dstProds =
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from product order by category");
            dgdProds.ReadOnly = true;
            dgdProds.DataSource = dstProds;
            dgdProds.DataMember = dstProds.Tables[0].ToString();
        }
    }
}
