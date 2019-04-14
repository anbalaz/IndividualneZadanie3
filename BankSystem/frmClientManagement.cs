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
        public frmClientManagement(string clientId)
        {
            InitializeComponent();
            _client = _bankManager.GetClientById(clientId);
            _bankAccount = _bankManager.GetBankAccountByClientId(clientId);
            InitializeClientInfo(clientId);
            InitializeBankAccountInfo(clientId);
            InitializeCreditCardsgrid(clientId);




        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void InitializeClientInfo(string clientId)
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

        private void InitializeBankAccountInfo(string clientId)
        {

            lblIBAN.Text = _bankAccount.IBAN.ToString();
            lblCreationDate.Text = _bankAccount.CreationAccountDate.ToString();
            lblCurrentSum.Text = _bankAccount.CurrentSum.ToString();
            lblLimit.Text = _bankAccount.Limit.ToString();
            if (_bankAccount.TerminationDate.ToString() != null)
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

        private void InitializeCreditCardsgrid(string clientId)

        {
            dtGrdVwCreditCards.DataSource = _bankManager.GetCreditCardListByClientId(clientId);

        }
    }
}
