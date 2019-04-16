using Data.Models;
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
    public partial class frmAccount : Form
    {
        private BankManager _bankManager = new BankManager();
        private Client _client;
        private BankAccount _bankAccount;
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
            InitializeCombobox();
            bttnUpdateClient.Visible = false;
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
            _client = _bankManager.GetClientById(clientId);
            _bankAccount = _bankManager.GetBankAccountByClientId(clientId);
            InitializeFieldsClientbyId(clientId);
            bttnCreateClient.Visible = false;
        }
        /// <summary>
        /// Used to add new client, returns message if it was successfull
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createClientBttn_Click(object sender, EventArgs e)
        {
            if (!identityCardTxtBx.Text.Equals(string.Empty) &&
                !firstNameTxtBx.Text.Equals(string.Empty) &&
                !lastNameTxtBx.Text.Equals(string.Empty) &&
                !townCmbBx.Text.Equals(string.Empty) &&
                !streetTxtBx.Text.Equals(string.Empty) &&
                !postalCodeNmrcTxtBx.Text.Equals(string.Empty) &&
                !streetNumberTxtBx.Text.Equals(string.Empty) &&
                !phoneNumberNmrcTxtBx.Text.Equals(string.Empty) &&
                !iBANtxtBx.Text.Equals(string.Empty) &&
                !emailTxtBx.Text.Equals(string.Empty))
            {
                MessageBox.Show(_bankManager.CreateClientAndBankAccount(identityCardTxtBx.Text,
                                                                        firstNameTxtBx.Text,
                                                                        lastNameTxtBx.Text,
                                                                        (int)townCmbBx.SelectedValue,
                                                                        streetTxtBx.Text,
                                                                        streetNumberTxtBx.Text,
                                                                        postalCodeNmrcTxtBx.Text,
                                                                        phoneNumberNmrcTxtBx.Text,
                                                                        emailTxtBx.Text,
                                                                        iBANtxtBx.Text,
                                                                        limitUpDwn.Value
                                                                        ));
            }
            else
            {
                MessageBox.Show("Please check if you selected all values");
            }
        }

        private void InitializeCombobox()
        {
            townCmbBx.DataSource = _bankManager.GetListOfTowns();
            townCmbBx.DisplayMember = nameof(Town.Name);
            townCmbBx.ValueMember = nameof(Town.Id);
            townCmbBx.BindingContext = new BindingContext();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!identityCardTxtBx.Text.Equals(string.Empty) &&
                !firstNameTxtBx.Text.Equals(string.Empty) &&
                !lastNameTxtBx.Text.Equals(string.Empty) &&
                !townCmbBx.Text.Equals(string.Empty) &&
                !streetTxtBx.Text.Equals(string.Empty) &&
                !postalCodeNmrcTxtBx.Text.Equals(string.Empty) &&
                !streetNumberTxtBx.Text.Equals(string.Empty) &&
                !phoneNumberNmrcTxtBx.Text.Equals(string.Empty) &&
                !iBANtxtBx.Text.Equals(string.Empty) &&
                !emailTxtBx.Text.Equals(string.Empty))
            {
                MessageBox.Show(_bankManager.UpdateClientAndBankAccount(_client.Id,
                                                                        (int)townCmbBx.SelectedValue,
                                                                        identityCardTxtBx.Text,
                                                                        firstNameTxtBx.Text,
                                                                        lastNameTxtBx.Text,
                                                                        streetTxtBx.Text,
                                                                        streetNumberTxtBx.Text,
                                                                        postalCodeNmrcTxtBx.Text,
                                                                        phoneNumberNmrcTxtBx.Text,
                                                                        emailTxtBx.Text,
                                                                        limitUpDwn.Value
                                                                        ));
                Close();
            }
            else
            {
                MessageBox.Show("Please check if you selected all values");
            }
        }

        private void InitializeFieldsClientbyId(int clientId)
        {
            InitializeCombobox();
            identityCardTxtBx.Text = _client.IdentityCard;
            firstNameTxtBx.Text = _client.FirstName;
            lastNameTxtBx.Text = _client.LastName;
            townCmbBx.SelectedIndex = (_client.Town.Id-1);
            streetTxtBx.Text = _client.Street;
            streetNumberTxtBx.Text = _client.StreetNumber;
            postalCodeNmrcTxtBx.Text = _client.PostalCode;
            phoneNumberNmrcTxtBx.Text = _client.PhoneNumber;
            emailTxtBx.Text = _client.Email;

            iBANtxtBx.Text = _bankAccount.IBAN;
            limitUpDwn.Value = _bankAccount.Limit;
        }
    }
}