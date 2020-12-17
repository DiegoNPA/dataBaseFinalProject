
namespace proyectoFinal
{
    partial class frmVerProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgdProds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdProds
            // 
            this.dgdProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProds.Location = new System.Drawing.Point(12, 12);
            this.dgdProds.Name = "dgdProds";
            this.dgdProds.RowHeadersWidth = 51;
            this.dgdProds.RowTemplate.Height = 24;
            this.dgdProds.Size = new System.Drawing.Size(991, 701);
            this.dgdProds.TabIndex = 0;
            this.dgdProds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 725);
            this.Controls.Add(this.dgdProds);
            this.Name = "frmVerProductos";
            this.Text = "frmVerProductos";
            this.Load += new System.EventHandler(this.frmVerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdProds;
    }
}