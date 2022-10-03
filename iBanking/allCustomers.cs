﻿using System;
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
    public partial class allCustomers : Form
    {
        public allCustomers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            dataGridViewAllCustomers.AutoGenerateColumns = true;
            iBankingEntities iBS = new iBankingEntities();
            var item = iBS.tblConsumerAccounts.ToList();
            dataGridViewAllCustomers.DataSource = item;
        }

        private void allCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
