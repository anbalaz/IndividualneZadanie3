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
    public partial class frmAccounts : Form
    {
        BankManager _bankManager = new BankManager();

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            //using (frmClientManagement newForm = new frmClientManagement())
            //{
            //    newForm.ShowDialog();
            //}
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            DataSet clients = _bankManager.GetSearchedClients(searchStringTxtBx.Text);

            searchedClientsDtGrdVw.DataSource = clients;
            searchedClientsDtGrdVw.DataMember = "Clients";
        }
    }
}
