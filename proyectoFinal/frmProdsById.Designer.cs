﻿
namespace proyectoFinal
{
    partial class frmProdsById
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
            this.dgdProds.Size = new System.Drawing.Size(828, 458);
            this.dgdProds.TabIndex = 0;
            this.dgdProds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdProds_CellContentClick);
            // 
            // frmProdsById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 478);
            this.Controls.Add(this.dgdProds);
            this.Name = "frmProdsById";
            this.Text = "frmProdsById";
            this.Load += new System.EventHandler(this.frmProdsById_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdProds;
    }
}