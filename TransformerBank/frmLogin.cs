using Data.Models;
using System;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class frmLogin : Form
    {
        private AtmManager _atmManager = new AtmManager();
        private int _count = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void confirmButtonbttn_Click(object sender, EventArgs e)
        {
            bool isTextInt = int.TryParse(nmrcTxtBxLogin.Text, out int login);

            if (String.IsNullOrEmpty(nmrcTxtBxLogin.Text) || String.IsNullOrEmpty(nmrcTxtBxPassword.Text) || !isTextInt)
            {
                MessageBox.Show("Please check if you filled all fields correctly");
            }
            else
            {
                CreditCard card = _atmManager.GetCreditCardByCardNumber(login);


                if (card.Id == 0)
                {
                    MessageBox.Show("WrongCard Number");
                }
                else if (card.ExpirationDate <= DateTime.Now || card.CreationCardDate >= DateTime.Now || card.IsCardBlocked)
                {
                    MessageBox.Show("Card is not Valid, please check with BankIslam Personel");
                }
                else if (card.Id != 0 && card.PasswordCard.Equals(nmrcTxtBxPassword.Text))
                {
                    Close();
                    using (frmWithdrawal newForm = new frmWithdrawal(card.CardNumber))
                    {
                        newForm.ShowDialog();
                    }
                }
                else
                {
                    _count++;
                    MessageBox.Show("Wrong password");

                    if (_count >= 3 && _atmManager.BlockCreditCard(card.CardNumber))
                    {
                        MessageBox.Show("Card has been blocked");
                    }
                }
            }
        }
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, have a nice day");
            Close();
        }
    }
}
