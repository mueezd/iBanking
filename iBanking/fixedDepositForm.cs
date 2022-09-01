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
    public partial class fixedDepositForm : Form
    {
        public fixedDepositForm()
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
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iBankingEntities iBS = new iBankingEntities();
            decimal accNo = Convert.ToDecimal(textBoxAccountNo.Text);
            var accounts = iBS.CustomerAccounts.Where(x => x.AccountNo == accNo).SingleOrDefault();

            FixedDeposit fdFrm = new FixedDeposit();
            fdFrm.AccountNo = Convert.ToDecimal(textBoxAccountNo.Text);
            fdFrm.Mode = comboBoxMode.SelectedItem.ToString();
            fdFrm.GBP = textBoxAmount.Text;
            fdFrm.Period = Convert.ToInt32(textBoxPeriod.Text);
            fdFrm.InterestRate = Convert.ToDecimal(textBoxInterest.Text);
            fdFrm.StartDate = DateTime.UtcNow;
            fdFrm.MaturityDate = (DateTime.UtcNow.AddDays(Convert.ToInt32(textBoxPeriod.Text)));
            fdFrm.MaturityAmount = ((Convert.ToDecimal(textBoxAmount.Text) * 
                Convert.ToInt32(textBoxPeriod.Text) * Convert.ToDecimal(textBoxInterest.Text)) / 
                (100 * 12 * 30)) + (Convert.ToDecimal(textBoxAmount.Text));

            iBS.FixedDeposits.Add(fdFrm);
            decimal amount = Convert.ToDecimal(textBoxAmount.Text);
            decimal totalAmount = Convert.ToDecimal(accounts.Balance);
            decimal fdAdmount = totalAmount - amount;
            accounts.Balance = fdAdmount;

            iBS.SaveChanges();
            MessageBox.Show("Fixed Deposit Started Now");
        }
    }
}
