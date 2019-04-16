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
            string clientIdentityCard = (searchedClientsDtGrdVw.SelectedCells[1].Value).ToString();
            int identity = _bankManager.ClientId(clientIdentityCard);

            if (identity != 0 && identity != BankManager.BANK_IDENTIY)
            {
                using (frmClientManagement newForm = new frmClientManagement(_bankManager.ClientId(clientIdentityCard)))
                {
                    newForm.ShowDialog();
                    Close();
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

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
