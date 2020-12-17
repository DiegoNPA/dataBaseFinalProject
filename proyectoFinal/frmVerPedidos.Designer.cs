
namespace proyectoFinal
{
    partial class frmVerPedidos
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
            this.dgdPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdPedidos
            // 
            this.dgdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdPedidos.Location = new System.Drawing.Point(12, 12);
            this.dgdPedidos.Name = "dgdPedidos";
            this.dgdPedidos.RowHeadersWidth = 51;
            this.dgdPedidos.RowTemplate.Height = 24;
            this.dgdPedidos.Size = new System.Drawing.Size(1474, 723);
            this.dgdPedidos.TabIndex = 0;
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 747);
            this.Controls.Add(this.dgdPedidos);
            this.Name = "frmVerPedidos";
            this.Text = "frmVerPedidos";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdPedidos;
    }
}