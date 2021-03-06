﻿using System;
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
    public partial class frmAddSeller : Form
    {
        public frmAddSeller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("insert into seller(sellerId,name,description,type) values({0},'{1}','{2}','{3}');",
            txtId.Text, txtName.Text, txtDesc.Text, txtType.Text);
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();
        }
    }
}
