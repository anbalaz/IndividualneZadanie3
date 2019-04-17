using System;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmCardPassword : Form
    {
        private BankManager _bankManager = new BankManager();
        private int _cardNumber;

        public frmCardPassword(int cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            string ret;
            if (int.TryParse(nmrcTxtBxPassword.Text, out int password) && password < 9999 && password > 1000)
            {
                ret = _bankManager.UpdateCardNewPassword(password, _cardNumber);
                Close();
            }
            else
            {
                ret = "Please insert only numbers!";
            }
            MessageBox.Show(ret);
        }
    }
}
