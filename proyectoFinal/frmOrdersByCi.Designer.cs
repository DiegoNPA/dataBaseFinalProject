
namespace proyectoFinal
{
    partial class frmOrdersByCi
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
            this.dgdOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdOrder
            // 
            this.dgdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdOrder.Location = new System.Drawing.Point(12, 12);
            this.dgdOrder.Name = "dgdOrder";
            this.dgdOrder.RowHeadersWidth = 51;
            this.dgdOrder.RowTemplate.Height = 24;
            this.dgdOrder.Size = new System.Drawing.Size(1543, 709);
            this.dgdOrder.TabIndex = 0;
            this.dgdOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdOrder_CellContentClick);
            // 
            // frmOrdersByCi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 728);
            this.Controls.Add(this.dgdOrder);
            this.Name = "frmOrdersByCi";
            this.Text = "frmOrdersByCi";
            this.Load += new System.EventHandler(this.frmOrdersByCi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdOrder;
    }
}