using Data.Models;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class frmWithdrawal : Form
    {
        private AtmManager _atmManager = new AtmManager();
        private BankAccount _userAccount;
        private BankAccount _bankAccount;

        public frmWithdrawal(int cardNumber)
        {
            InitializeComponent();

            InitializeFields(cardNumber);
        }

        private void InitializeFields(int cardNumber)
        {
            _userAccount = _atmManager.GetBankAccountByCreditNumber(cardNumber);
            _bankAccount = _atmManager.GetBankAccountByClientId(1);

            lblIBANSender.Text = _userAccount.IBAN;
            lblSumSender.Text = _userAccount.CurrentSum.ToString();
            lblLimitSender.Text = _userAccount.Limit.ToString();

        }

        private void bttnOk_Click(object sender, System.EventArgs e)
        {
            if (_atmManager.IsTransactionUnderLimit(_userAccount.CurrentSum,_userAccount.Limit,lmtUpDwnSumToTransfer.Value)) 
            {
                MessageBox.Show(_atmManager.CreateTransaction(_userAccount.Id,
                                                _bankAccount.Id,
                                                lmtUpDwnSumToTransfer.Value,
                                                "ATM Withdraval"
                                                ));
                Close();
            }
            else
            {
                MessageBox.Show("Insufficient founds");
            }
        }

        private void bttnCancel_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Have a nice day");
            Close();
        }
    }
}