using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmMain : Form
    {
        private BankManager _bankManager = new BankManager();
        public const int BANK_IDENTIY = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            int identity = _bankManager.ClientId(txtBxSearchIdentity.Text);
            if (identity != 0 && identity!= BANK_IDENTIY)
            {
                using (frmClientManagement newForm = new frmClientManagement(_bankManager.ClientId(txtBxSearchIdentity.Text)))
                {
                    newForm.ShowDialog();
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
    }
}
