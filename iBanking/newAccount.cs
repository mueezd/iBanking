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
    public partial class newAccount : Form
    {
        string Gender = string.Empty;
        string MaritalStatus = string.Empty;
        decimal AccountNo;

        iBankingEntities iBE;
        MemoryStream ms;
     
        public newAccount()
        {
            InitializeComponent();
            loadDate();
            loadAccount();
            loadState();
        }

        private void loadState()
        {
            comboBoxAccountType.Items.Add("Current Account");
            comboBoxAccountType.Items.Add("Savings Account");
        }

        private void loadAccount()
        {
            iBE = new iBankingEntities();
            var item = iBE.tblConsumerAccounts.ToArray();
            AccountNo = item.LastOrDefault().AccountNo + 1;
            textBoxAccountNo.Text = Convert.ToString(AccountNo);
        }

        private void loadDate()
        {
            //throw new NotImplementedException();
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnPictureUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBoxCustomer.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAccountType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Account Type.");
            }
            else if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Account Name.");
            }
            else if (TextBoxPhoneNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Phone Number.");
            }
            else if (textBoxAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address.");
            }
            else if (textBoxBalance.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Balance.");
            }
            else if (textBoxFathersName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Father's Name.");
            }
            else if (textBoxMothersName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Mother's Name.");
            }
            else if (!rbMale.Checked && !rbFemale.Checked && !rbOther.Checked)
            {
                MessageBox.Show("Please Select Gender.");
            }
            else if (!rbMarried.Checked && !rbUnmarried.Checked)
            {
                MessageBox.Show("Please Select Marital Status.");
            }
            else
            {
                string accName = textBoxName.Text;
                string AccType = comboBoxAccountType.Text;

                var accInfo = iBE.tblConsumerAccounts.Where(d => d.Name == accName && d.AccountType == AccType).FirstOrDefault();
                if (accInfo != null)
                {
                    MessageBox.Show("Account already exists !!!");
                    return;
                }
                else
                {
                    // Gender Selection By Radio Button.
                    if (rbMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else if (rbFemale.Checked)
                    {
                        Gender = "Female";
                    }
                    else if (rbOther.Checked)
                    {
                        Gender = "Other";
                    }
                    //Marital Status selection by Radio Button.

                    if (rbMarried.Checked)
                    {
                        MaritalStatus = "Married";
                    }
                    else if (rbUnmarried.Checked)
                    {
                        MaritalStatus = "Un-Married";
                    }

                    iBE = new iBankingEntities();
                    tblConsumerAccount cac = new tblConsumerAccount();
                    cac.AccountNo = Convert.ToDecimal(textBoxAccountNo.Text);
                    cac.AccountType = comboBoxAccountType.SelectedItem.ToString();
                    cac.Name = textBoxName.Text;
                    cac.DoB = dateTimePicker1.Value;
                    cac.PhoneNo = TextBoxPhoneNo.Text;
                    cac.Address = textBoxAddress.Text;
                    cac.Gender = Gender;
                    cac.MaritalStatus = MaritalStatus;
                    cac.FathersName = textBoxFathersName.Text;
                    cac.MothersName = textBoxMothersName.Text;
                    cac.Balance = Convert.ToDecimal(textBoxBalance.Text);
                    cac.Date = Convert.ToDateTime(lblDate.Text);
                    cac.Picture = ms.ToArray();
                    iBE.tblConsumerAccounts.Add(cac);
                    iBE.SaveChanges();
                    MessageBox.Show("Customer Account Information Saved Successfully");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // All Value of form clear 
            textBoxAccountNo.Clear();
            textBoxAddress.Clear();
            textBoxBalance.Clear();
            textBoxFathersName.Clear();
            textBoxMothersName.Clear();
            textBoxName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            rbMarried.Checked = false;
            rbUnmarried.Checked = false;
        }
    }
}
