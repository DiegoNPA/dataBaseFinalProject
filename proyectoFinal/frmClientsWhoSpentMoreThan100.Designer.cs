﻿
namespace proyectoFinal
{
    partial class frmClientsWhoSpentMoreThan100
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
            this.dgdC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdC
            // 
            this.dgdC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdC.Location = new System.Drawing.Point(12, 12);
            this.dgdC.Name = "dgdC";
            this.dgdC.RowHeadersWidth = 51;
            this.dgdC.RowTemplate.Height = 24;
            this.dgdC.Size = new System.Drawing.Size(776, 426);
            this.dgdC.TabIndex = 0;
            // 
            // frmClientsWhoSpentMoreThan100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgdC);
            this.Name = "frmClientsWhoSpentMoreThan100";
            this.Text = "frmClientsWhoSpentMoreThan100";
            this.Load += new System.EventHandler(this.frmClientsWhoSpentMoreThan100_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdC;
    }
}