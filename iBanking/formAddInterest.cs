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
    public partial class formAddInterest : Form
    {
        iBankingEntities idb = new iBankingEntities();
        public formAddInterest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                tblInterest inRate = new tblInterest();
                inRate.AccountNo = Convert.ToInt32(comboBoxAccountNo.Text);
                //inRate.AccountName =  
                inRate.InterestRate = Convert.ToDecimal(textBoxInterest.Text);
                inRate.ThresholdAmount = Convert.ToDecimal(textBoxAmount.Text);

                idb.tblInterests.Add(inRate);
                idb.SaveChanges();

                loadData();
            }
            else
            {
                //Update Code

                int idn = Int32.Parse(textBoxName.Text);

                var data = idb.tblInterests.Where(x => x.Id == idn).FirstOrDefault();
                if(data != null)
                {
                    data.InterestRate = Convert.ToDecimal(textBoxInterest.Text);
                    data.ThresholdAmount = Convert.ToDecimal(textBoxAmount.Text);
                    idb.SaveChanges();
                }
            }
        }

        private void formAddInterest_Load(object sender, EventArgs e)
        {
            loadData();
            clearData();

            // load Combo box data
            var cboxdata = idb.tblConsumerAccounts.ToList();

            comboBoxAccountNo.DataSource = cboxdata;
            comboBoxAccountNo.DisplayMember = "AccountNo";

        }

        private void loadData()
        {
            dataGridViewInterest.AutoGenerateColumns = false;

            var data = idb.tblInterests.Select(d => new { d.Id, d.AccountNo, d.AccountName, d.InterestRate, d.ThresholdAmount }).ToList();

            dataGridViewInterest.Columns[0].DataPropertyName = "Id";
            dataGridViewInterest.Columns[1].DataPropertyName = "AccountNo";
            dataGridViewInterest.Columns[2].DataPropertyName = "AccountName";
            dataGridViewInterest.Columns[3].DataPropertyName = "InterestRate";
            dataGridViewInterest.Columns[4].DataPropertyName = "ThresholdAmount";

            dataGridViewInterest.DataSource = data;
        }

        private void clearData()
        {
            textBoxName.Text = "";
            textBoxInterest.Text = "";
            textBoxAmount.Text = "";
        }

        private void dataGridViewInterest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        btnSave.Text = "Update";
                        textBoxId.Text = dataGridViewInterest.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Convert.ToInt32(textBoxId.Text);

                        var data = idb.tblInterests.Where(x => x.Id == idn).FirstOrDefault();
                        break;  
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
