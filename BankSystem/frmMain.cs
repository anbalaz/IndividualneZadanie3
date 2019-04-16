using System;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmMain : Form
    {
        private BankManager _bankManager = new BankManager();

        public frmMain()
        {
            InitializeComponent();
            RefreshData();
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            int identity = _bankManager.ClientId(txtBxSearchIdentity.Text);
            if (identity != 0 && identity != BankManager.BANK_IDENTIY)
            {
                using (frmClientManagement newForm = new frmClientManagement(_bankManager.ClientId(txtBxSearchIdentity.Text)))
                {
                    if (newForm.ShowDialog() == DialogResult.No)
                    {
                        RefreshData();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no clients with searched Identity Card number");
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }

        public void RefreshData()
        {
            lblSumMoney.Text = _bankManager.GetSumOfMoneyOnAccounts().ToString();
            lblNumberOfClients.Text = _bankManager.GetCountOfClients().ToString();
            dtGrdVwTopTowns.DataSource = _bankManager.GetTopTowns();
            dtGrdVwTopTowns.DataMember = "Towns";
            dtGrdVwTopClients.DataSource = _bankManager.GetTopClients();
            dtGrdVwTopClients.DataMember = "Clients";
            dtGrdVwMonths.DataSource = _bankManager.GetNewclients();
            dtGrdVwMonths.DataMember = "NewClients";
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtGrdVwTopTowns.DataSource = _bankManager.GetTopTowns();
            dtGrdVwTopTowns.DataMember = "Towns";
            dtGrdVwTopClients.DataSource = _bankManager.GetTopClients();
            dtGrdVwTopClients.DataMember = "Clients";
            dtGrdVwMonths.DataSource = _bankManager.GetNewclients();
            dtGrdVwMonths.DataMember = "NewClients";
        }
    }
}