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
        BankManager _bankManager = new BankManager();
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }

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
    }
}
