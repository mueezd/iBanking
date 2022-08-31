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
    public partial class depositForm : Form
    {
        public depositForm()
        {
            InitializeComponent();
            loadDate();
            loadMode();


        }

        private void loadMode()
        {
            comboBoxMode.Items.Add("Cash");
            comboBoxMode.Items.Add("Chaque");

        }

        private void loadDate()
        {
            lbldate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            iBankingEntities context = new iBankingEntities();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();

            dp.Date = Convert.ToDateTime(lbldate.Text);
            dp.AccountNo = Convert.ToDecimal(textBoxEnterAcNo.Text);
            dp.Name = textBoxAccountName.Text;
            dp.OldBalance = Convert.ToDecimal(textBoxoldBalance.Text);
            dp.Mode = comboBoxMode.SelectedItem.ToString();
            dp.DepositAmount = Convert.ToDecimal(textBoxDepositAmount.Text);

            context.Deposits.Add(dp);
            context.SaveChanges();

            decimal b = Convert.ToDecimal(textBoxEnterAcNo.Text);
            var item = (from u in context.CustomerAccounts where u.AccountNo == b select u).FirstOrDefault();

            item.Balance = item.Balance + Convert.ToDecimal(textBoxDepositAmount.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Successfully");
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            iBankingEntities context = new iBankingEntities();
            decimal b = Convert.ToDecimal(textBoxEnterAcNo.Text);

            var item = (from u in context.CustomerAccounts
                        where u.AccountNo == b
                        select u).FirstOrDefault();

            textBoxAccountName.Text = item.Name;
            textBoxoldBalance.Text = Convert.ToString(item.Balance);
        }

        private void depositForm_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
    }
}
