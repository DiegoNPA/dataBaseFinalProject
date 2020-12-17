
namespace proyectoFinal
{
    partial class frmVerClientes
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
            this.dgdClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdClient
            // 
            this.dgdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdClient.Location = new System.Drawing.Point(12, 12);
            this.dgdClient.Name = "dgdClient";
            this.dgdClient.RowHeadersWidth = 51;
            this.dgdClient.RowTemplate.Height = 24;
            this.dgdClient.Size = new System.Drawing.Size(921, 501);
            this.dgdClient.TabIndex = 0;
            // 
            // frmVerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 525);
            this.Controls.Add(this.dgdClient);
            this.Name = "frmVerClientes";
            this.Text = "frmVerClientes";
            this.Load += new System.EventHandler(this.frmVerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdClient;
    }
}