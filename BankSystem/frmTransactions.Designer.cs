namespace BankSystem
{
    partial class frmTransactions
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
            this.AllTransactionsDtGrdVw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactionsDtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTransactionsDtGrdVw
            // 
            this.AllTransactionsDtGrdVw.AllowUserToAddRows = false;
            this.AllTransactionsDtGrdVw.AllowUserToDeleteRows = false;
            this.AllTransactionsDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTransactionsDtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.AllTransactionsDtGrdVw.Name = "AllTransactionsDtGrdVw";
            this.AllTransactionsDtGrdVw.ReadOnly = true;
            this.AllTransactionsDtGrdVw.Size = new System.Drawing.Size(560, 337);
            this.AllTransactionsDtGrdVw.TabIndex = 4;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.AllTransactionsDtGrdVw);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactionsDtGrdVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllTransactionsDtGrdVw;
    }
}