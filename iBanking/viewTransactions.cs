using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBanking
{
    public partial class viewTransactions : Form
    {
        iBankingEntities iBs = new iBankingEntities();
        public viewTransactions()
        {
            InitializeComponent();
        }

        private void btnViewDeposits_Click(object sender, EventArgs e)
        {
            gvDeposit.AutoGenerateColumns = true;
            var item = iBs.tblDeposits.Where(d => d.AccountNo == userClass.AccountNo).ToList();
            gvDeposit.DataSource = item;
        }

        private void btnViewWithdrawals_Click(object sender, EventArgs e)
        {
            gvWithdrawals.AutoGenerateColumns = true;
            var item = iBs.tblWithdrawals.Where(d => d.AccountNo == userClass.AccountNo).ToList();
            gvWithdrawals.DataSource = item;
        }

        private void btnViewTransfers_Click(object sender, EventArgs e)
        {
            gvTransfers.AutoGenerateColumns = true;
            var item = iBs.Transfers.Where(d => d.AccountNo == userClass.AccountNo).ToList();
            gvTransfers.DataSource = item;


        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            gvPayments.AutoGenerateColumns = true;
            var item = iBs.tblPayments.Where(d => d.AccountId == userClass.AccountNo).ToList();
            gvPayments.DataSource = item;
        }
    }
}
