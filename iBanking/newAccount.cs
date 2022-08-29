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
            comboBoxState.Items.Add("London");
            comboBoxAccountType.Items.Add("Current Account");
            comboBoxAccountType.Items.Add("Savings Account");
        }

        private void loadAccount()
        {
            iBE = new iBankingEntities();
            var item = iBE.CustomerAccounts.ToArray();
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
            CustomerAccount cac = new CustomerAccount();
            cac.AccountNo = Convert.ToDecimal(textBoxAccountNo.Text);
            cac.AccountType = comboBoxAccountType.SelectedItem.ToString();
            cac.Name = textBoxName.Text;
            cac.DoB = dateTimePicker1.Value;
            cac.PhoneNo = TextBoxPhoneNo.Text;
            cac.Address = textBoxAddress.Text;
            cac.State = comboBoxState.SelectedItem.ToString();
            cac.Gender = Gender;
            cac.MaritalStatus = MaritalStatus;
            cac.FathersName = textBoxFathersName.Text;
            cac.MothersName = textBoxMothersName.Text;
            cac.Balance = Convert.ToDecimal(textBoxBalance.Text);
            cac.Date = Convert.ToDateTime(lblDate.Text);
            cac.Picture = ms.ToArray();
            iBE.CustomerAccounts.Add(cac);
            iBE.SaveChanges();
            MessageBox.Show("Customer Account Information Saved Successfully");
        }
    }
}
