﻿
namespace proyectoFinal
{
    partial class frmMostExpensiveProduct
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
            this.dgdP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdP
            // 
            this.dgdP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdP.Location = new System.Drawing.Point(12, 12);
            this.dgdP.Name = "dgdP";
            this.dgdP.RowHeadersWidth = 51;
            this.dgdP.RowTemplate.Height = 24;
            this.dgdP.Size = new System.Drawing.Size(942, 497);
            this.dgdP.TabIndex = 0;
            this.dgdP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdP_CellContentClick);
            // 
            // frmMostExpensiveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 521);
            this.Controls.Add(this.dgdP);
            this.Name = "frmMostExpensiveProduct";
            this.Text = "frmMostExpensiveProduct";
            this.Load += new System.EventHandler(this.frmMostExpensiveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdP;
    }
}