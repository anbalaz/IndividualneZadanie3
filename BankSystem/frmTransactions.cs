﻿using Data.Repositories;
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

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            SetUpTransactionsGridSet();
        }



        private void SetUpTransactionsGridSet()
        {
            TransactionsRepositories transactionsRepositories = new TransactionsRepositories();
            AllTransactionsDtGrdVw.DataSource = transactionsRepositories.GetAllTransactions();
            AllTransactionsDtGrdVw.DataMember = "Transactions";
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(int clientId)
        {
            InitializeComponent();
        }
    }
}
