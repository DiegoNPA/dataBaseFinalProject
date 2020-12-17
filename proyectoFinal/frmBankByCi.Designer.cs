
namespace proyectoFinal
{
    partial class frmBankByCi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
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
            this.dgdBank.Size = new System.Drawing.Size(505, 379);
            this.dgdBank.TabIndex = 0;
            this.dgdBank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdBank_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CardNumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bank:";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(621, 77);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(100, 22);
            this.txtCard.TabIndex = 3;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(621, 109);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(100, 22);
            this.txtBank.TabIndex = 4;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(561, 150);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(129, 52);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // frmBankByCi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 405);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdBank);
            this.Name = "frmBankByCi";
            this.Text = "frmBankByCi";
            this.Load += new System.EventHandler(this.frmBankByCi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Button Agregar;
    }
}