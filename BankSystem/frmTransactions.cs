using Data.Repositories;
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
    public partial class frmTransactions : Form
    {
        private BankManager _bankManager = new BankManager();

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            SetUpAllTransactionsGridSet();
        }



        private void SetUpAllTransactionsGridSet()
        {
            AllTransactionsDtGrdVw.DataSource = _bankManager.GetAllTransactions();
            AllTransactionsDtGrdVw.DataMember = "Transactions";
        }

        private void SetUpTransactionsByIdGridSet(string identityCard)
        {
            AllTransactionsDtGrdVw.DataSource = _bankManager.GetTransactionsByClientId(identityCard);
            AllTransactionsDtGrdVw.DataMember = "Transactions";
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(string clientId)
        {
            InitializeComponent();
            SetUpTransactionsByIdGridSet(clientId);
        }
    }
}
