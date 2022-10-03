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
    public partial class makePayment : Form
    {
        iBankingEntities iBs = new iBankingEntities();
        public makePayment()
        {
            InitializeComponent();
            loadPayeeName();
            dateLoad();
            loadAccount();
        }
        private void dateLoad()
        {
            lblGetDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
      

        public void loadPayeeName()
        {
            tblPayee payeeName = new tblPayee();

            //while (iBs.Read(payeeName))

            //{
            //    comboBoxPayeeName.Items.Add(dr[0]).ToString();
            //}

            var AccNoData = iBs.tblPayees.ToList();
            comboBoxPayeeName.DataSource = AccNoData;
            comboBoxPayeeName.DisplayMember = "PayeeName";
        }
        private void loadAccount()
        {
            tblConsumerAccount consumerAc = new tblConsumerAccount();

            var acNo = iBs.tblConsumerAccounts.Select(a => new {a.AccountNo}).Where(a => a.AccountNo == userClass.AccountNo).FirstOrDefault();
            var acName = iBs.tblConsumerAccounts.Select(a => new { a.Name, a.AccountNo}).Where(a => a.AccountNo == userClass.AccountNo).FirstOrDefault();

            lblAccountNo.Text = Convert.ToString(acNo.AccountNo);
            lblAccountName.Text = Convert.ToString(acName.Name);
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (textBoxAgainstOf.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Against Of");
            }
            else if (textBoxAmount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Payment Amount");
            }
            else
            {
                tblPayment Payment = new tblPayment();
                tblPayee payee = new tblPayee();

                var payeeId = iBs.tblPayees.Select(a => new { a.PayeeId, a.PayeeName }).Where(a => comboBoxPayeeName.Text == a.PayeeName).FirstOrDefault();

                Payment.AccountId = Convert.ToInt32(lblAccountNo.Text);
                Payment.PayeeId = Convert.ToInt32(payeeId.PayeeId);
                Payment.Date = Convert.ToDateTime(lblGetDate.Text);
                Payment.AganestOf = textBoxAgainstOf.Text;
                Payment.Description = textBoxDescription.Text;
                Payment.Amount = Convert.ToDecimal(textBoxAmount.Text);
                Payment.PayeeName = comboBoxPayeeName.Text;
                iBs.tblPayments.Add(Payment);

                decimal b = Convert.ToDecimal(lblAccountNo.Text);
                var item = (from u in iBs.tblConsumerAccounts
                            where u.AccountNo == b
                            select u).FirstOrDefault();

                item.Balance = item.Balance - Convert.ToDecimal(textBoxAmount.Text);
                iBs.SaveChanges();
                MessageBox.Show("Payment Successfully");
            }
        }
    }
}
