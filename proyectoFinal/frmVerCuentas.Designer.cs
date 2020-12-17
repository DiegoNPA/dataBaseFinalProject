
namespace proyectoFinal
{
    partial class frmVerCuentas
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
            this.dgdBank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdBank)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdBank
            // 
            this.dgdBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdBank.Location = new System.Drawing.Point(12, 12);
            this.dgdBank.Name = "dgdBank";
            this.dgdBank.RowHeadersWidth = 51;
            this.dgdBank.RowTemplate.Height = 24;
            this.dgdBank.Size = new System.Drawing.Size(776, 426);
            this.dgdBank.TabIndex = 0;
            // 
            // frmVerCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgdBank);
            this.Name = "frmVerCuentas";
            this.Text = "frmVerCuentas";
            this.Load += new System.EventHandler(this.frmVerCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdBank;
    }
}