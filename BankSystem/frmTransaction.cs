using Data.Models;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmTransaction : Form
    {
        private BankManager _bankManager = new BankManager();
        private BankAccount _sender;
        private BankAccount _receiver;
        private int _senderId;
        private int _receiverId;

        public frmTransaction(int bankAccountFrom)
        {
            InitializeComponent();
        }

        public frmTransaction(int bankAccountFrom, int bankAccountTo)
        {
            InitializeComponent();

            _senderId = bankAccountFrom;
            _receiverId = bankAccountTo;
            Refreshdata(bankAccountFrom, bankAccountTo);
        }

        public void Refreshdata(int bankAccountFrom, int bankAccountTo)
        {
            _sender = _bankManager.GetBankAccountByClientId(bankAccountFrom);
            _receiver = _bankManager.GetBankAccountByClientId(bankAccountTo);
            lblIBANSender.Text = _sender.IBAN;
            lblSumSender.Text = _sender.CurrentSum.ToString();
            lblLimitSender.Text = _sender.Limit.ToString();

            lblIBANReceiver.Text = _receiver.IBAN;
            lblSumReceiver.Text = _receiver.CurrentSum.ToString();
            lblLimitReceiver.Text = _receiver.Limit.ToString();

            txtBxCS.Visible = false; ;
            txtBxSS.Visible = false; ;
            txtBxVS.Visible = false; ;
            txtBxMessage.Visible = false;
            lblVS.Visible = false;
            lblCS.Visible = false;
            lblSS.Visible = false;
            lblMessage.Visible = false;

            if (_receiver.Id == 1)
            {
                lblTransaction.Text = "WITHDRAWAL";
                lblSumR.Visible = false;
                lblSumReceiver.Visible = false;
                lblLimitR.Visible = false;
                lblLimitReceiver.Visible = false;
            }
            else
            {
                lblTransaction.Text = "DEPOSIT";
                lblSumSender.Visible = false;
                lblSumS.Visible = false;
                lblLimitS.Visible = false;
                lblLimitSender.Visible = false;
            }
        }

        private void bttnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bttnOk_Click(object sender, System.EventArgs e)
        {
            string ret;

            if (!_bankManager.IsTransactionUnderLimit(_sender.CurrentSum, _sender.Limit, lmtUpDwnSumToTransfer.Value))
            {
                ret = "Insufficient funds";
            }
            else if (lmtUpDwnSumToTransfer.Value > 0)
            {
                ret = _bankManager.CreateTransaction(_sender.Id,
                                               _receiver.Id,
                                               lmtUpDwnSumToTransfer.Value,
                                               Category(),
                                               txtBxVS.Text,
                                               txtBxCS.Text,
                                               txtBxSS.Text,
                                               txtBxMessage.Text
                                               );
            }
            else
            {
                ret = "Please insert value";
            }
            Refreshdata(_senderId,_receiverId);
            MessageBox.Show(ret);
        }

        private string Category()
        {
            string ret;
            if ((_sender.Id != 1) && (_receiver.Id != 1))
            {
                ret = "Transaction";
            }
            else if (_sender.Id == 1)
            {
                ret = "Bank withdrawal";
            }
            else
            {
                ret = "Deposit";
            }
            return ret;
        }
    }
}
