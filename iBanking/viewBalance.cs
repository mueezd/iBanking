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
    public partial class viewBalance : Form
    {
        iBankingEntities iBs = new iBankingEntities();
        public viewBalance()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            gvViewBalance.AutoGenerateColumns = false;

            gvViewBalance.Columns[0].DataPropertyName = "CustomerId";
            gvViewBalance.Columns[1].DataPropertyName = "AccountNo";
            gvViewBalance.Columns[2].DataPropertyName = "Name";
            gvViewBalance.Columns[3].DataPropertyName = "AccountType";
            gvViewBalance.Columns[4].DataPropertyName = "Date";
            gvViewBalance.Columns[5].DataPropertyName = "Balance";

            if (userClass.userRole == 1)
            {

                var data = iBs.tblConsumerAccounts.Select(d => new { d.CustomerId, d.AccountNo, d.Name, d.AccountType, d.Date, d.Balance }).ToList();
                gvViewBalance.DataSource = data;
            }
            else
            {
                var data = iBs.tblConsumerAccounts.Select(d => new { d.CustomerId, d.AccountNo, d.Name, d.AccountType, d.Date, d.Balance }).Where(d => d.AccountNo == userClass.AccountNo).ToList();
                gvViewBalance.DataSource = data;
            }
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            loadData();
            //iBs = new iBankingEntities();
            //var item = iBs.tblConsumerAccounts.ToList();
            //gvViewBalance.DataSource = item;
        }
    }
}
