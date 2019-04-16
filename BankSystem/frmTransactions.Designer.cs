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
            this.components = new System.ComponentModel.Container();
            this.AllTransactionsDtGrdVw = new System.Windows.Forms.DataGridView();
            this.bttnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactionsDtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTransactionsDtGrdVw
            // 
            this.AllTransactionsDtGrdVw.AllowUserToAddRows = false;
            this.AllTransactionsDtGrdVw.AllowUserToDeleteRows = false;
            this.AllTransactionsDtGrdVw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTransactionsDtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllTransactionsDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTransactionsDtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.AllTransactionsDtGrdVw.Name = "AllTransactionsDtGrdVw";
            this.AllTransactionsDtGrdVw.ReadOnly = true;
            this.AllTransactionsDtGrdVw.RowHeadersVisible = false;
            this.AllTransactionsDtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllTransactionsDtGrdVw.Size = new System.Drawing.Size(813, 426);
            this.AllTransactionsDtGrdVw.TabIndex = 4;
            // 
            // bttnClose
            // 
            this.bttnClose.Location = new System.Drawing.Point(750, 448);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(75, 23);
            this.bttnClose.TabIndex = 5;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 483);
            this.ControlBox = false;
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.AllTransactionsDtGrdVw);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.AllTransactionsDtGrdVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllTransactionsDtGrdVw;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Timer timer1;
    }
}