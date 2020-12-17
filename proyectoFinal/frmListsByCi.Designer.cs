
namespace proyectoFinal
{
    partial class frmListsByCi
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgdList.Size = new System.Drawing.Size(823, 457);
            this.dgdList.TabIndex = 0;
            this.dgdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdList_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListsByCi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgdList);
            this.Name = "frmListsByCi";
            this.Text = "frmListsByCi";
            this.Load += new System.EventHandler(this.frmListsByCi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdList;
        private System.Windows.Forms.Button button1;
    }
}