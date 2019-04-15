using Data.Models;
using System;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmClientManagement : Form
    {
        private BankManager _bankManager = new BankManager();
        private Client _client;
        private BankAccount _bankAccount;
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        //public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int clientId)
        {
            InitializeComponent();
            RefreshData(clientId);
        }

        private void RefreshData(int clientId)
        {
            _client = _bankManager.GetClientById(clientId);
            _bankAccount = _bankManager.GetBankAccountByClientId(clientId);
            InitializeClientInfo();
            InitializeBankAccountInfo();
            InitializeCreditCardsgrid(clientId);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            var clientId = _client.Id;
            using (frmAccount newForm = new frmAccount(clientId))
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshData(clientId);
                }
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            int clientId = _client.Id;
            using (frmTransaction newForm = new frmTransaction(1, clientId))
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshData(clientId);
                }
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            int clientId = _client.Id;
            using (frmTransaction newForm = new frmTransaction(clientId, 1))
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshData(clientId);
                }
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(_client.Id))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            int clientId = _client.Id;
            using (frmTransaction newForm = new frmTransaction(clientId))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            var clientId = _client.Id;
            if (MessageBox.Show("Are you sure you wat to close this account?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(_bankManager.CloseBankAccount(_client.Id));
                _bankManager.GetCreditCardListByClientId(clientId).ForEach(card => _bankManager.AccessCreditCard(card.CardNumber,1));
                RefreshData(clientId);
            }
        }

        private void InitializeClientInfo()
        {

            lblIdentity.Text = _client.IdentityCard;
            lblFirstName.Text = _client.FirstName;
            lblLastName.Text = _client.LastName;
            lblTown.Text = _client.Town.Name;
            lblStreet.Text = _client.Street;
            lblStreetNumber.Text = _client.StreetNumber;
            lblPostalCode.Text = _client.PostalCode;
            lblPhoneNumber.Text = _client.PhoneNumber;
            lblEmail.Text = _client.Email;
        }

        private void InitializeBankAccountInfo()
        {

            lblIBAN.Text = _bankAccount.IBAN.ToString();
            lblCreationDate.Text = _bankAccount.CreationAccountDate.ToString();
            lblCurrentSum.Text = _bankAccount.CurrentSum.ToString();
            lblLimit.Text = _bankAccount.Limit.ToString();

            if (_bankAccount.TerminationDate != DateTime.MinValue)
            {
                lblTerminationDate.Text = _bankAccount.TerminationDate.ToString();
                MessageBox.Show("The Account was closed");
                cmdWithdrawal.Enabled = false;
                cmdDeposit.Enabled = false;
                cmdUpdate.Enabled = false;
                cmdNewTransaction.Enabled = false;
                cmdCloseAccount.Enabled = false;
            }
        }

        private void InitializeCreditCardsgrid(int clientId)

        {
            dtGrdVwCreditCards.DataSource = _bankManager.GetCreditCardListByClientId(clientId);
        }

        private void bttnUnblockCard_Click(object sender, EventArgs e)
        {
            int cardToUpdate = Convert.ToInt32(dtGrdVwCreditCards.SelectedCells[2].Value);

            if (Convert.ToInt32(dtGrdVwCreditCards.SelectedCells[5].Value) > 0)
            {
                _bankManager.AccessCreditCard(cardToUpdate, 0);
            }
            else
            {
                _bankManager.AccessCreditCard(cardToUpdate, 1);
            }
            RefreshData(_client.Id);
        }
    }
}