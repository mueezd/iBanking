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
    public partial class balanceSheetForm : Form
    {
        public balanceSheetForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            iBankingEntities ibs = new iBankingEntities();

            decimal b = Convert.ToDecimal(textBoxAccountNo.Text);
            var item = (from u in ibs.Debits
                        where u.AccountNo == b
                        select u);

            dataGridViewWithdrawal.DataSource = item.ToList();

            var item1 = (from u in ibs.Deposits
                        where u.AccountNo == b
                        select u);
            dataGridViewDeposit.DataSource = item1.ToList();

            var item2 = (from u in ibs.Transfers
                         where u.AccountNo == b
                         select u);
            dataGridViewTransfer.DataSource = item2.ToList();
        }
    }
}
