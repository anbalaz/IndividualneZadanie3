using System;
using System.Data;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAccounts : Form
    {
        BankManager _bankManager = new BankManager();

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            if (!_bankManager.ClientId(txtBxIdentity.Text).Equals(string.Empty))
            {
                using (frmClientManagement newForm = new frmClientManagement(_bankManager.ClientId(txtBxIdentity.Text)))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There are no clients with searched Identity Card number");
            }
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            DataSet clients = _bankManager.GetSearchedClients(searchStringTxtBx.Text);

            searchedClientsDtGrdVw.DataSource = clients;
            searchedClientsDtGrdVw.DataMember = "Clients";
        }
    }
}
