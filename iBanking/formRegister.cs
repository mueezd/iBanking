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
    public partial class formRegister : Form
    {
        iBankingEntities iBS;
        BindingList<tblConsumerAccount> bi;
        public formRegister()
        {
            InitializeComponent();
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            if(textBoxAccountNo.Text == string.Empty && textBoxAccountName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Account Information");
            }
            else
            {
                iBankingEntities context = new iBankingEntities();
                decimal b = Convert.ToDecimal(textBoxAccountNo.Text);

                var item = (from u in context.tblConsumerAccounts
                            where u.AccountNo == b
                            select u).FirstOrDefault();

                textBoxAccountName.Text = item.Name;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != String.Empty && textBoxPassword.Text != String.Empty && textBoxConPassword.Text != String.Empty)
            {
                if (textBoxPassword.Text == textBoxConPassword.Text)
                {
                    iBankingEntities context = new iBankingEntities();
                    tblUser dp = new tblUser();

                    dp.UserName = textBoxUserName.Text;
                    if (textBoxPassword.Text == textBoxConPassword.Text)
                    {
                        dp.Password = textBoxPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                    dp.RoleId = 2;
                    dp.EmployeeId = null;
                    dp.Name = textBoxAccountName.Text;
                    dp.AccountNo = Convert.ToInt32(textBoxAccountNo.Text);
                    context.tblUsers.Add(dp);
                    context.SaveChanges();
                    MessageBox.Show("SignUp Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Please enter same password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }








            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login_form log = new Login_form();
            log.ShowDialog();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConPassword.UseSystemPasswordChar = true;
            }
        }

        private void txttBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
