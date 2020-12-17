
namespace proyectoFinal
{
    partial class frmVerVendedores
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
            this.dgdSeller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdSeller
            // 
            this.dgdSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdSeller.Location = new System.Drawing.Point(12, 29);
            this.dgdSeller.Name = "dgdSeller";
            this.dgdSeller.RowHeadersWidth = 51;
            this.dgdSeller.RowTemplate.Height = 24;
            this.dgdSeller.Size = new System.Drawing.Size(776, 382);
            this.dgdSeller.TabIndex = 0;
            this.dgdSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdSeller_CellContentClick);
            // 
            // frmVerVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgdSeller);
            this.Name = "frmVerVendedores";
            this.Text = "frmVerVendedores";
            this.Load += new System.EventHandler(this.frmVerVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdSeller;
    }
}