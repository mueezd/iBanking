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
            if (textBoxAccountNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Account No");
            }
            else
            {
                iBankingEntities ibs = new iBankingEntities();

                decimal b = Convert.ToDecimal(textBoxAccountNo.Text);
                var item = (from u in ibs.tblWithdrawals
                            where u.AccountNo == b
                            select u);

                dataGridViewWithdrawal.DataSource = item.ToList();

                var item1 = (from u in ibs.tblDeposits
                             where u.AccountNo == b
                             select u);
                dataGridViewDeposit.DataSource = item1.ToList();

                var item2 = (from u in ibs.Transfers
                             where u.AccountNo == b
                             select u);
                dataGridViewTransfer.DataSource = item2.ToList();

                var item3 = (from u in ibs.tblPayments
                             where u.AccountId == b
                             select u);
                GvPayments.DataSource = item3.ToList();
            }
        }
    }
}
