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
    public partial class frmClientManagement : Form
    {
        private BankManager _bankManager = new BankManager();
        private Client _client;
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
            InitializeClientGrid(clientId);






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

        private void InitializeClientGrid(string clientId)
        {
            
           lblIdentity.Text= _client.IdentityCard;
           lblFirstName.Text= _client.FirstName;
           lblLastName.Text= _client.LastName;
           lblTown.Text= _client.Town.Name;
           lblStreet.Text= _client.Street;
           lblStreetNumber.Text= _client.StreetNumber;
           lblPostalCode.Text= _client.PostalCode;
           lblPhoneNumber.Text= _client.PhoneNumber;
           lblEmail.Text= _client.Email;
        }
    }
}
