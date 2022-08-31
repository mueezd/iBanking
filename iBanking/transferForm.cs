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
    public partial class transferForm : Form
    {
        public transferForm()
        {
            InitializeComponent();
            loadDate();
        }

        private void loadDate()
        {
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            iBankingEntities iBS = new iBankingEntities();
            decimal b = Convert.ToDecimal(textBoxFromAccountNo.Text);
            var item = (from u in iBS.CustomerAccounts
                        where u.AccountNo == b
                        select u).FirstOrDefault();

            textBoxFromAcName.Text = item.Name;
            textBoxBalance.Text = Convert.ToString(item.Balance);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            iBankingEntities iBS = new iBankingEntities();
            decimal b = Convert.ToDecimal(textBoxFromAccountNo.Text);
            var item = (from u in iBS.CustomerAccounts
                        where u.AccountNo == b
                        select u).FirstOrDefault(); 

            decimal b1 = Convert.ToDecimal(textBoxBalance.Text);
            decimal totalBlance = Convert.ToDecimal(textBoxAmount.Text);
            decimal transferAc = Convert.ToDecimal(textBoxToAccount.Text);
            if (b1 > totalBlance)
            {
                CustomerAccount item2 = (from u in iBS.CustomerAccounts
                                         where u.AccountNo == transferAc
                                         select u).FirstOrDefault();

                item2.Balance = item2.Balance + totalBlance;
                item.Balance = item.Balance - totalBlance;
                //iBS.SaveChanges();

                Transfer transfer = new Transfer();

                transfer.AccountNo = Convert.ToDecimal(textBoxFromAccountNo.Text);
                transfer.Date = DateTime.UtcNow;
                transfer.Name = textBoxFromAcName.Text;
                transfer.Balance = Convert.ToDecimal(textBoxAmount.Text);
                transfer.ToTransfer = Convert.ToDecimal(textBoxToAccount.Text);

                iBS.Transfers.Add(transfer);
                iBS.SaveChanges();
                MessageBox.Show("Transfer Successfully");
            }
        }

        private void transferForm_Load(object sender, EventArgs e)
        {

        }
    }
}
