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
    public partial class withdrawForm : Form
    {
        public withdrawForm()
        {
            InitializeComponent();
            loadDate();
            loadData();
        }

        private void loadDate()
        {
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void loadData()
        {
            comboBoxMode.Items.Add("Cash");
            comboBoxMode.Items.Add("Chaque");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            iBankingEntities ibs = new iBankingEntities();
            decimal b = Convert.ToDecimal(textBoxAccountNo.Text);
            var item = (from u in ibs.CustomerAccounts
                        where u.AccountNo == b
                        select u).FirstOrDefault();

            textBoxAccountName.Text = item.Name;
            textBoxBalance.Text = Convert.ToString(item.Balance);
        }

        private void btnCompleateTrans_Click(object sender, EventArgs e)
        {
            iBankingEntities ibs = new iBankingEntities();
            newAccount nAcc = new newAccount();
            Debit dp = new Debit();

            dp.Date = Convert.ToDateTime(lblDate.Text);
            dp.AccountNo = Convert.ToDecimal(textBoxAccountNo.Text);
            dp.Name = textBoxAccountName.Text;
            dp.OldBalance = Convert.ToDecimal(textBoxBalance.Text);
            dp.Mode = comboBoxMode.SelectedItem.ToString();
            dp.DebitAmount = Convert.ToDecimal(textBoxAmount.Text);
            ibs.Debits.Add(dp);
            ibs.SaveChanges();

            decimal b = Convert.ToDecimal(textBoxAccountNo.Text);
            var item = (from u in ibs.CustomerAccounts
                        where u.AccountNo == b
                        select u).FirstOrDefault();

            item.Balance = item.Balance - Convert.ToDecimal(textBoxAmount.Text);
            ibs.SaveChanges();
            MessageBox.Show("Widthwran Completed");


          
        }
    }
}
