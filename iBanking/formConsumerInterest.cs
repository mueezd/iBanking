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
    public partial class formConsumerInterest : Form
    {
        iBankingEntities iBs = new iBankingEntities();
        public formConsumerInterest()
        {
            InitializeComponent();
            recInterest();
        }
        private void recInterest()
        {
            gvInterest.AutoGenerateColumns = false;

            gvInterest.Columns[0].DataPropertyName = "AccountNo";
            gvInterest.Columns[1].DataPropertyName = "AccountName";
            gvInterest.Columns[2].DataPropertyName = "Balance";
            gvInterest.Columns[3].DataPropertyName = "InterestRate";
            gvInterest.Columns[4].DataPropertyName = "InterestAmount";


            var interestDate = iBs.tblProcessInterests.Select(i => new { i.AccountNo, i.AccountName, i.Balance, i.InterestRate, i.InterestAmount }).Where(i => i.AccountNo == userClass.AccountNo).ToList();

            gvInterest.DataSource = interestDate;



        }
    }
}
