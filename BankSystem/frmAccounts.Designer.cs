namespace BankSystem
{
    partial class frmAccounts
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
            this.searchStringTxtBx = new System.Windows.Forms.TextBox();
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchedClientsDtGrdVw = new System.Windows.Forms.DataGridView();
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.txtBxIdentity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchedClientsDtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // searchStringTxtBx
            // 
            this.searchStringTxtBx.Location = new System.Drawing.Point(102, 27);
            this.searchStringTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.searchStringTxtBx.Name = "searchStringTxtBx";
            this.searchStringTxtBx.Size = new System.Drawing.Size(235, 20);
            this.searchStringTxtBx.TabIndex = 13;
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(341, 24);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 23);
            this.cmdFindClient.TabIndex = 12;
            this.cmdFindClient.Text = "Find client";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "PLEASE INSERT SEARCH VALUE";
            // 
            // searchedClientsDtGrdVw
            // 
            this.searchedClientsDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedClientsDtGrdVw.Location = new System.Drawing.Point(45, 53);
            this.searchedClientsDtGrdVw.Name = "searchedClientsDtGrdVw";
            this.searchedClientsDtGrdVw.Size = new System.Drawing.Size(476, 150);
            this.searchedClientsDtGrdVw.TabIndex = 15;
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(262, 271);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // txtBxIdentity
            // 
            this.txtBxIdentity.Location = new System.Drawing.Point(188, 246);
            this.txtBxIdentity.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxIdentity.Name = "txtBxIdentity";
            this.txtBxIdentity.Size = new System.Drawing.Size(235, 20);
            this.txtBxIdentity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLEASE INSERT CLIENT IDENTITY CARD NUMBER";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxIdentity);
            this.Controls.Add(this.searchedClientsDtGrdVw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchStringTxtBx);
            this.Controls.Add(this.cmdFindClient);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.searchedClientsDtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchStringTxtBx;
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView searchedClientsDtGrdVw;
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.TextBox txtBxIdentity;
        private System.Windows.Forms.Label label1;
    }
}