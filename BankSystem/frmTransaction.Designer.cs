namespace BankSystem
{
    partial class frmTransaction
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
            this.lblTransaction = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBxSender = new System.Windows.Forms.GroupBox();
            this.grpBxReceiver = new System.Windows.Forms.GroupBox();
            this.lblSumS = new System.Windows.Forms.Label();
            this.lblIBANSender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSumSender = new System.Windows.Forms.Label();
            this.lblLimitSender = new System.Windows.Forms.Label();
            this.lblLimitS = new System.Windows.Forms.Label();
            this.lblLimitReceiver = new System.Windows.Forms.Label();
            this.lblLimitR = new System.Windows.Forms.Label();
            this.lblSumReceiver = new System.Windows.Forms.Label();
            this.lblSumR = new System.Windows.Forms.Label();
            this.lblIBANReceiver = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxVS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lmtUpDwnSumToTransfer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxSS = new System.Windows.Forms.TextBox();
            this.txtBxCS = new System.Windows.Forms.TextBox();
            this.txtBxMessage = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOk = new System.Windows.Forms.Button();
            this.grpBxSender.SuspendLayout();
            this.grpBxReceiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lmtUpDwnSumToTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(12, 9);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(35, 13);
            this.lblTransaction.TabIndex = 8;
            this.lblTransaction.Text = "label4";
            // 
            // grpBxSender
            // 
            this.grpBxSender.Controls.Add(this.lblLimitSender);
            this.grpBxSender.Controls.Add(this.lblLimitS);
            this.grpBxSender.Controls.Add(this.lblSumSender);
            this.grpBxSender.Controls.Add(this.lblSumS);
            this.grpBxSender.Controls.Add(this.lblIBANSender);
            this.grpBxSender.Controls.Add(this.label4);
            this.grpBxSender.Location = new System.Drawing.Point(37, 25);
            this.grpBxSender.Name = "grpBxSender";
            this.grpBxSender.Size = new System.Drawing.Size(207, 159);
            this.grpBxSender.TabIndex = 9;
            this.grpBxSender.TabStop = false;
            this.grpBxSender.Text = "SENDER";
            // 
            // grpBxReceiver
            // 
            this.grpBxReceiver.Controls.Add(this.lblLimitReceiver);
            this.grpBxReceiver.Controls.Add(this.lblSumR);
            this.grpBxReceiver.Controls.Add(this.lblLimitR);
            this.grpBxReceiver.Controls.Add(this.label10);
            this.grpBxReceiver.Controls.Add(this.lblSumReceiver);
            this.grpBxReceiver.Controls.Add(this.lblIBANReceiver);
            this.grpBxReceiver.Location = new System.Drawing.Point(325, 25);
            this.grpBxReceiver.Name = "grpBxReceiver";
            this.grpBxReceiver.Size = new System.Drawing.Size(200, 159);
            this.grpBxReceiver.TabIndex = 10;
            this.grpBxReceiver.TabStop = false;
            this.grpBxReceiver.Text = "RECEIVER";
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
            // lblSumSender
            // 
            this.lblSumSender.AutoSize = true;
            this.lblSumSender.Location = new System.Drawing.Point(6, 87);
            this.lblSumSender.Name = "lblSumSender";
            this.lblSumSender.Size = new System.Drawing.Size(62, 13);
            this.lblSumSender.TabIndex = 14;
            this.lblSumSender.Text = "current sum";
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
            // lblLimitReceiver
            // 
            this.lblLimitReceiver.AutoSize = true;
            this.lblLimitReceiver.Location = new System.Drawing.Point(16, 132);
            this.lblLimitReceiver.Name = "lblLimitReceiver";
            this.lblLimitReceiver.Size = new System.Drawing.Size(24, 13);
            this.lblLimitReceiver.TabIndex = 22;
            this.lblLimitReceiver.Text = "limit";
            // 
            // lblLimitR
            // 
            this.lblLimitR.AutoSize = true;
            this.lblLimitR.Location = new System.Drawing.Point(16, 109);
            this.lblLimitR.Name = "lblLimitR";
            this.lblLimitR.Size = new System.Drawing.Size(35, 13);
            this.lblLimitR.TabIndex = 21;
            this.lblLimitR.Text = "LIMIT";
            // 
            // lblSumReceiver
            // 
            this.lblSumReceiver.AutoSize = true;
            this.lblSumReceiver.Location = new System.Drawing.Point(16, 87);
            this.lblSumReceiver.Name = "lblSumReceiver";
            this.lblSumReceiver.Size = new System.Drawing.Size(62, 13);
            this.lblSumReceiver.TabIndex = 20;
            this.lblSumReceiver.Text = "current sum";
            // 
            // lblSumR
            // 
            this.lblSumR.AutoSize = true;
            this.lblSumR.Location = new System.Drawing.Point(16, 64);
            this.lblSumR.Name = "lblSumR";
            this.lblSumR.Size = new System.Drawing.Size(87, 13);
            this.lblSumR.TabIndex = 17;
            this.lblSumR.Text = "CURRENT SUM";
            // 
            // lblIBANReceiver
            // 
            this.lblIBANReceiver.AutoSize = true;
            this.lblIBANReceiver.Location = new System.Drawing.Point(16, 39);
            this.lblIBANReceiver.Name = "lblIBANReceiver";
            this.lblIBANReceiver.Size = new System.Drawing.Size(27, 13);
            this.lblIBANReceiver.TabIndex = 18;
            this.lblIBANReceiver.Text = "iban";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "IBAN";
            // 
            // txtBxVS
            // 
            this.txtBxVS.Location = new System.Drawing.Point(35, 229);
            this.txtBxVS.Name = "txtBxVS";
            this.txtBxVS.Size = new System.Drawing.Size(65, 20);
            this.txtBxVS.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "SUM TO TRANSFER";
            // 
            // lmtUpDwnSumToTransfer
            // 
            this.lmtUpDwnSumToTransfer.DecimalPlaces = 2;
            this.lmtUpDwnSumToTransfer.Location = new System.Drawing.Point(35, 304);
            this.lmtUpDwnSumToTransfer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lmtUpDwnSumToTransfer.Name = "lmtUpDwnSumToTransfer";
            this.lmtUpDwnSumToTransfer.Size = new System.Drawing.Size(120, 20);
            this.lmtUpDwnSumToTransfer.TabIndex = 37;
            this.lmtUpDwnSumToTransfer.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "VS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "SS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "KS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "MESSAGE FOR RECEIVER";
            // 
            // txtBxSS
            // 
            this.txtBxSS.Location = new System.Drawing.Point(126, 229);
            this.txtBxSS.Name = "txtBxSS";
            this.txtBxSS.Size = new System.Drawing.Size(65, 20);
            this.txtBxSS.TabIndex = 42;
            // 
            // txtBxKS
            // 
            this.txtBxCS.Location = new System.Drawing.Point(220, 229);
            this.txtBxCS.Name = "txtBxKS";
            this.txtBxCS.Size = new System.Drawing.Size(65, 20);
            this.txtBxCS.TabIndex = 43;
            // 
            // txtBxMessage
            // 
            this.txtBxMessage.Location = new System.Drawing.Point(322, 229);
            this.txtBxMessage.Name = "txtBxMessage";
            this.txtBxMessage.Size = new System.Drawing.Size(200, 20);
            this.txtBxMessage.TabIndex = 44;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(319, 301);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 45;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnOk
            // 
            this.bttnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnOk.Location = new System.Drawing.Point(450, 301);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 46;
            this.bttnOk.Text = "Ok";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 336);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.txtBxMessage);
            this.Controls.Add(this.txtBxCS);
            this.Controls.Add(this.txtBxSS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxVS);
            this.Controls.Add(this.lmtUpDwnSumToTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBxReceiver);
            this.Controls.Add(this.grpBxSender);
            this.Controls.Add(this.lblTransaction);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            this.grpBxSender.ResumeLayout(false);
            this.grpBxSender.PerformLayout();
            this.grpBxReceiver.ResumeLayout(false);
            this.grpBxReceiver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lmtUpDwnSumToTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransaction;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBxSender;
        private System.Windows.Forms.TextBox txtBxVS;
        private System.Windows.Forms.Label lblLimitSender;
        private System.Windows.Forms.Label lblLimitS;
        private System.Windows.Forms.Label lblSumSender;
        private System.Windows.Forms.Label lblSumS;
        private System.Windows.Forms.Label lblIBANSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBxReceiver;
        private System.Windows.Forms.Label lblLimitReceiver;
        private System.Windows.Forms.Label lblSumR;
        private System.Windows.Forms.Label lblLimitR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSumReceiver;
        private System.Windows.Forms.Label lblIBANReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lmtUpDwnSumToTransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBxSS;
        private System.Windows.Forms.TextBox txtBxCS;
        private System.Windows.Forms.TextBox txtBxMessage;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOk;
    }
}