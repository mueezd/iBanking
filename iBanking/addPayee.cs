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
    public partial class addPayee : Form
    {
        iBankingEntities iDb = new iBankingEntities();
        public addPayee()
        {
            InitializeComponent();
            payeeBindGrid();
        }

        private void payeeBindGrid()
        {
            dataGridViewPayee.AutoGenerateColumns = true;
            iBankingEntities iDb = new iBankingEntities();
            var item = iDb.tblPayees.ToList();
            dataGridViewPayee.DataSource = item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxPayeeName.Text == string.Empty && textBoxEmailId.Text == string.Empty && textBoxPhoneNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter -Payee Name-, -Email id-,-Phone No-");
            }
            else
            {
                tblPayee payee = new tblPayee();
                payee.PayeeName = textBoxPayeeName.Text;
                payee.EmailId = textBoxEmailId.Text;
                payee.PhoneNo = textBoxPhoneNo.Text;
                iDb.tblPayees.Add(payee);
                iDb.SaveChanges();
                MessageBox.Show("New Payee Added Successfully"); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxPayeeName.Clear();
            textBoxEmailId.Clear();
            textBoxPhoneNo.Clear();
        }
    }
}
