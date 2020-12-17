
namespace proyectoFinal
{
    partial class frmVerListas
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
            this.dgdList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdList
            // 
            this.dgdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdList.Location = new System.Drawing.Point(12, 12);
            this.dgdList.Name = "dgdList";
            this.dgdList.RowHeadersWidth = 51;
            this.dgdList.RowTemplate.Height = 24;
            this.dgdList.Size = new System.Drawing.Size(776, 426);
            this.dgdList.TabIndex = 0;
            // 
            // frmVerListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgdList);
            this.Name = "frmVerListas";
            this.Text = "frmVerListas";
            this.Load += new System.EventHandler(this.frmVerListas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdList;
    }
}