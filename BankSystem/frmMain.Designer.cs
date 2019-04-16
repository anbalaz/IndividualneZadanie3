namespace BankSystem
{
    partial class frmMain
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
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.txtBxSearchIdentity = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrdVwTopTowns = new System.Windows.Forms.DataGridView();
            this.lblNumberOfClients = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSumMoney = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dtGrdVwTopClients = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dtGrdVwMonths = new System.Windows.Forms.DataGridView();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwTopTowns)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwTopClients)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(512, 102);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 23);
            this.cmdFindClient.TabIndex = 2;
            this.cmdFindClient.Text = "Find client";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(512, 192);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(512, 253);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(112, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(512, 313);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // txtBxSearchIdentity
            // 
            this.txtBxSearchIdentity.Location = new System.Drawing.Point(273, 105);
            this.txtBxSearchIdentity.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxSearchIdentity.Name = "txtBxSearchIdentity";
            this.txtBxSearchIdentity.Size = new System.Drawing.Size(235, 20);
            this.txtBxSearchIdentity.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 352);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtGrdVwTopTowns);
            this.tabPage1.Controls.Add(this.lblNumberOfClients);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblSumMoney);
            this.tabPage1.Controls.Add(this.lbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOP 5 TOWNS";
            // 
            // dtGrdVwTopTowns
            // 
            this.dtGrdVwTopTowns.AllowUserToAddRows = false;
            this.dtGrdVwTopTowns.AllowUserToDeleteRows = false;
            this.dtGrdVwTopTowns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwTopTowns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwTopTowns.Location = new System.Drawing.Point(9, 131);
            this.dtGrdVwTopTowns.Name = "dtGrdVwTopTowns";
            this.dtGrdVwTopTowns.ReadOnly = true;
            this.dtGrdVwTopTowns.RowHeadersVisible = false;
            this.dtGrdVwTopTowns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwTopTowns.Size = new System.Drawing.Size(240, 176);
            this.dtGrdVwTopTowns.TabIndex = 10;
            // 
            // lblNumberOfClients
            // 
            this.lblNumberOfClients.AutoSize = true;
            this.lblNumberOfClients.Location = new System.Drawing.Point(174, 78);
            this.lblNumberOfClients.Name = "lblNumberOfClients";
            this.lblNumberOfClients.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfClients.TabIndex = 9;
            this.lblNumberOfClients.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "NUMBER OF CLIENTS";
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Location = new System.Drawing.Point(174, 45);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSumMoney.Size = new System.Drawing.Size(13, 13);
            this.lblSumMoney.TabIndex = 7;
            this.lblSumMoney.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 45);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(127, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "MONEY ON ACCOUNTS";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtGrdVwTopClients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Overview2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "MOST WEALTHY CLIENTS";
            // 
            // dtGrdVwTopClients
            // 
            this.dtGrdVwTopClients.AllowUserToAddRows = false;
            this.dtGrdVwTopClients.AllowUserToDeleteRows = false;
            this.dtGrdVwTopClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwTopClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwTopClients.Location = new System.Drawing.Point(7, 52);
            this.dtGrdVwTopClients.Name = "dtGrdVwTopClients";
            this.dtGrdVwTopClients.ReadOnly = true;
            this.dtGrdVwTopClients.RowHeadersVisible = false;
            this.dtGrdVwTopClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwTopClients.Size = new System.Drawing.Size(240, 240);
            this.dtGrdVwTopClients.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dtGrdVwMonths);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(259, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Overview3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NEW CLIENTS LAST 6 MONTHS";
            // 
            // dtGrdVwMonths
            // 
            this.dtGrdVwMonths.AllowUserToAddRows = false;
            this.dtGrdVwMonths.AllowUserToDeleteRows = false;
            this.dtGrdVwMonths.AllowUserToResizeRows = false;
            this.dtGrdVwMonths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwMonths.Enabled = false;
            this.dtGrdVwMonths.Location = new System.Drawing.Point(6, 51);
            this.dtGrdVwMonths.Name = "dtGrdVwMonths";
            this.dtGrdVwMonths.ReadOnly = true;
            this.dtGrdVwMonths.RowHeadersVisible = false;
            this.dtGrdVwMonths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwMonths.Size = new System.Drawing.Size(240, 240);
            this.dtGrdVwMonths.TabIndex = 14;
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Location = new System.Drawing.Point(510, 29);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(112, 23);
            this.bttnRefresh.TabIndex = 12;
            this.bttnRefresh.Text = "REFRESH";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtBxSearchIdentity);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwTopTowns)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwTopClients)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.TextBox txtBxSearchIdentity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrdVwTopTowns;
        private System.Windows.Forms.Label lblNumberOfClients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSumMoney;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGrdVwTopClients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtGrdVwMonths;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Timer timer1;
    }
}

