namespace TransformerBank
{
    partial class frmWithdrawal
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
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lmtUpDwnSumToTransfer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxSender = new System.Windows.Forms.GroupBox();
            this.lblLimitSender = new System.Windows.Forms.Label();
            this.lblLimitS = new System.Windows.Forms.Label();
            this.lblSumSender = new System.Windows.Forms.Label();
            this.lblSumS = new System.Windows.Forms.Label();
            this.lblIBANSender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lmtUpDwnSumToTransfer)).BeginInit();
            this.grpBxSender.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnOk
            // 
            this.bttnOk.Location = new System.Drawing.Point(441, 309);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 61;
            this.bttnOk.Text = "Ok";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(310, 309);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 60;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lmtUpDwnSumToTransfer
            // 
            this.lmtUpDwnSumToTransfer.DecimalPlaces = 2;
            this.lmtUpDwnSumToTransfer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lmtUpDwnSumToTransfer.Location = new System.Drawing.Point(37, 229);
            this.lmtUpDwnSumToTransfer.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lmtUpDwnSumToTransfer.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lmtUpDwnSumToTransfer.Name = "lmtUpDwnSumToTransfer";
            this.lmtUpDwnSumToTransfer.Size = new System.Drawing.Size(120, 20);
            this.lmtUpDwnSumToTransfer.TabIndex = 52;
            this.lmtUpDwnSumToTransfer.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "MONEY TO WITHDRAWAL";
            // 
            // grpBxSender
            // 
            this.grpBxSender.Controls.Add(this.lblLimitSender);
            this.grpBxSender.Controls.Add(this.lblLimitS);
            this.grpBxSender.Controls.Add(this.lblSumSender);
            this.grpBxSender.Controls.Add(this.lblSumS);
            this.grpBxSender.Controls.Add(this.lblIBANSender);
            this.grpBxSender.Controls.Add(this.label4);
            this.grpBxSender.Location = new System.Drawing.Point(28, 33);
            this.grpBxSender.Name = "grpBxSender";
            this.grpBxSender.Size = new System.Drawing.Size(428, 159);
            this.grpBxSender.TabIndex = 48;
            this.grpBxSender.TabStop = false;
            this.grpBxSender.Text = "SENDER";
            // 
            // lblLimitSender
            // 
            this.lblLimitSender.AutoSize = true;
            this.lblLimitSender.Location = new System.Drawing.Point(6, 132);
            this.lblLimitSender.Name = "lblLimitSender";
            this.lblLimitSender.Size = new System.Drawing.Size(24, 13);
            this.lblLimitSender.TabIndex = 16;
            this.lblLimitSender.Text = "limit";
            // 
            // lblLimitS
            // 
            this.lblLimitS.AutoSize = true;
            this.lblLimitS.Location = new System.Drawing.Point(6, 109);
            this.lblLimitS.Name = "lblLimitS";
            this.lblLimitS.Size = new System.Drawing.Size(35, 13);
            this.lblLimitS.TabIndex = 15;
            this.lblLimitS.Text = "LIMIT";
            // 
            // lblSumSender
            // 
            this.lblSumSender.AutoSize = true;
            this.lblSumSender.Location = new System.Drawing.Point(6, 87);
            this.lblSumSender.Name = "lblSumSender";
            this.lblSumSender.Size = new System.Drawing.Size(62, 13);
            this.lblSumSender.TabIndex = 14;
            this.lblSumSender.Text = "current sum";
            // 
            // lblSumS
            // 
            this.lblSumS.AutoSize = true;
            this.lblSumS.Location = new System.Drawing.Point(6, 64);
            this.lblSumS.Name = "lblSumS";
            this.lblSumS.Size = new System.Drawing.Size(87, 13);
            this.lblSumS.TabIndex = 11;
            this.lblSumS.Text = "CURRENT SUM";
            // 
            // lblIBANSender
            // 
            this.lblIBANSender.AutoSize = true;
            this.lblIBANSender.Location = new System.Drawing.Point(6, 39);
            this.lblIBANSender.Name = "lblIBANSender";
            this.lblIBANSender.Size = new System.Drawing.Size(27, 13);
            this.lblIBANSender.TabIndex = 12;
            this.lblIBANSender.Text = "iban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "IBAN";
            // 
            // frmWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 347);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.lmtUpDwnSumToTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBxSender);
            this.Name = "frmWithdrawal";
            this.Text = "frmWithdrawalDeposit";
            ((System.ComponentModel.ISupportInitialize)(this.lmtUpDwnSumToTransfer)).EndInit();
            this.grpBxSender.ResumeLayout(false);
            this.grpBxSender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.NumericUpDown lmtUpDwnSumToTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxSender;
        private System.Windows.Forms.Label lblLimitSender;
        private System.Windows.Forms.Label lblLimitS;
        private System.Windows.Forms.Label lblSumSender;
        private System.Windows.Forms.Label lblSumS;
        private System.Windows.Forms.Label lblIBANSender;
        private System.Windows.Forms.Label label4;
    }
}