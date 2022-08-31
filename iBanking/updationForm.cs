using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBanking
{
    public partial class updationForm : Form
    {
        iBankingEntities iBS;
        MemoryStream ms;
        BindingList<CustomerAccount> bi;
        public updationForm()
        {
            InitializeComponent();
        }

        private void updationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            bi = new BindingList<CustomerAccount>();
            iBS = new iBankingEntities();
            decimal accNo = Convert.ToDecimal(textBoxAccountNo.Text);

            var item = iBS.CustomerAccounts.Where(a => a.AccountNo == accNo);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridViewCustomerDetails.DataSource = bi;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bi = new BindingList<CustomerAccount>();
            iBS = new iBankingEntities();

            var item = iBS.CustomerAccounts.Where(a => a.Name == textBoxName.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridViewCustomerDetails.DataSource= bi;
        }

        private void dataGridViewCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iBS = new iBankingEntities();
            decimal accNo = Convert.ToDecimal(dataGridViewCustomerDetails.Rows[e.RowIndex].Cells[1].Value);

            var item = iBS.CustomerAccounts.Where(a => a.AccountNo == accNo).FirstOrDefault();
            lblShowId.Text = item.CustomerId.ToString();
            textBoxAccountNo.Text = item.AccountNo.ToString();
            textBoxName.Text = item.Name;
            textBoxFathersName.Text = item.FathersName;
            textBoxMothersName.Text = item.MothersName;
            textBoxPhoneNo.Text = item.PhoneNo;
            textBoxAddress.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBoxCustomerPicture.Image = Image.FromStream(ms);
            textBoxState.Text = item.State;

            if (item.Gender == "Male")
            {
                rbMale.Checked = true;
            }
            else if(item.Gender == "Female")
            {
                rbFemale.Checked = true;
            }
            else if(item.Gender == "Other")
            {
                rbOthers.Checked = true;
            }

            if (item.MaritalStatus == "Married")
            {
                rbMarried.Checked = true;
            }
            else if(item.MaritalStatus == "Un-Married")
            {
                rbUnMarried.Checked = true;
            }

        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openlg = new OpenFileDialog();

            if (openlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openlg.FileName);
                pictureBoxCustomerPicture.Image = img;
                ms = new MemoryStream();
                img.Save(ms,img.RawFormat);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridViewCustomerDetails.CurrentRow.Index);
            iBS = new iBankingEntities();
            int a = Convert.ToInt32(lblShowId.Text);

            CustomerAccount acc = iBS.CustomerAccounts.First(s => s.CustomerId.Equals(a));
            iBS.CustomerAccounts.Remove(acc);
            iBS.SaveChanges();
        }
    }
}
