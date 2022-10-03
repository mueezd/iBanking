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
        BindingList<tblConsumerAccount> bi;
        public updationForm()
        {
            InitializeComponent();
        }

        private void updationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            bi = new BindingList<tblConsumerAccount>();
            iBS = new iBankingEntities();
            decimal accNo = Convert.ToDecimal(textBoxAccountNo.Text);

            var item = iBS.tblConsumerAccounts.Where(a => a.AccountNo == accNo);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridViewCustomerDetails.DataSource = bi;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bi = new BindingList<tblConsumerAccount>();
            iBS = new iBankingEntities();

            var item = iBS.tblConsumerAccounts.Where(a => a.Name == textBoxName.Text);
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

            var item = iBS.tblConsumerAccounts.Where(a => a.AccountNo == accNo).FirstOrDefault();
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
            //textBoxState.Text = item.State;

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

            tblConsumerAccount acc = iBS.tblConsumerAccounts.First(s => s.CustomerId.Equals(a));
            iBS.tblConsumerAccounts.Remove(acc);
            iBS.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxAccountNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Account No");
            }
            else if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Name");
            }
            else if (textBoxFathersName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Father's Name");
            }
            else if (textBoxMothersName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Mother's Name");
            }
            else
            {
                iBS = new iBankingEntities();
                decimal accountNo = Convert.ToDecimal(textBoxAccountNo.Text);
                tblConsumerAccount customerAc = iBS.tblConsumerAccounts.First(s => s.AccountNo.Equals(accountNo));
                customerAc.AccountNo = Convert.ToDecimal(textBoxAccountNo.Text);
                customerAc.Name = textBoxName.Text;
                customerAc.Date = dateTimePickerDoB.Value;
                customerAc.FathersName = textBoxFathersName.Text;
                customerAc.MothersName = textBoxMothersName.Text;
                customerAc.PhoneNo = textBoxPhoneNo.Text;
                if (rbMale.Checked == true)
                {
                    customerAc.Gender = "Male";
                }
                else
                {
                    if (rbFemale.Checked == true)
                    {
                        customerAc.Gender = "Female";
                    }
                }
                if (rbMarried.Checked == true)
                {
                    customerAc.MaritalStatus = "Married";
                }
                else
                {
                    if (rbUnMarried.Checked == true)
                    {
                        customerAc.MaritalStatus = "Un-Married";
                    }
                }

                Image img = pictureBoxCustomerPicture.Image;
                if (ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    customerAc.Picture = ms.ToArray();
                }

                customerAc.Address = textBoxAddress.Text;
                //customerAc.State = textBoxState.Text;
                iBS.SaveChanges();
                MessageBox.Show("Update Information Successfully");
            }
        }
    }
}
