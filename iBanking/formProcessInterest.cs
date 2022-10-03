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
    public partial class formProcessInterest : Form
    {
        public formProcessInterest()
        {
            InitializeComponent();
        }

        public void processInterest()
        {
            iBankingEntities db = new iBankingEntities();
            var accountList = db.tblPayments.Select(m => m.AccountId).ToList();
            for (int i = 0; i < accountList.Count(); i++)
            {
                int accountNo = accountList[i];
                decimal interestRate = db.tblInterests.FirstOrDefault(m => m.AccountNo == accountNo).InterestRate;
                var amountListFromDb = db.Database.SqlQuery<decimal>($"SELECT Amount FROM tblPayment WHERE Amount > (select ThresholdAmount FROM tblInterest WHERE AccountNo = {accountNo}) AND (SELECT [Date] FROM tblConsumerAccount WHERE AccountNo = {accountNo}) <= GETDATE()");
                var amountList = amountListFromDb.ToList();
                if (amountList.Count > 3)
                {
                    var totalAmount = amountList.Sum();
                    var interest = (totalAmount * interestRate) / 100;
                    var exec = db.tblProcessInterests.Add(new tblProcessInterest { AccountNo = accountNo, InterestRate = interestRate, Balance = totalAmount, AccountName = "Mamun Chudna", TotalAmount = totalAmount + interest, InterestAmount = interest });
                    db.SaveChanges();
                }
            }
        }
        public void viewInterest()
        {
            iBankingEntities db = new iBankingEntities();
            var interestDate = db.tblProcessInterests.Select(a => new { a.AccountNo, a.AccountName, a.Balance, a.InterestRate, a.InterestAmount, a.TotalAmount }).ToList();
            dataGridViewProcessInterest.DataSource = interestDate;
        }

        private void btnProcessInterest_Click(object sender, EventArgs e)
        {
            //processInterest();
            viewInterest();
        }
    }
}
