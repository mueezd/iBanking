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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            iBankingEntities db = new iBankingEntities();

            if (txtBoxUserName.Text != string.Empty || txtBoxPassword.Text != string.Empty)
            {
                var user1 = db.tblUsers.FirstOrDefault(a => a.UserName.Equals(txtBoxUserName.Text));

                if (user1!=null)
                {
                    if (user1.Password.Equals(txtBoxPassword.Text))
                    {
                        this.Hide();
                        userClass.Userid = user1.Id;
                        userClass.userName = user1.UserName;
                        userClass.userRole = user1.RoleId;
                        userClass.AccountNo = Convert.ToInt32(user1.AccountNo);
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User Name Or Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Account!");
                }
            }
            else
            {
                MessageBox.Show("Please enter User Name and Password");
            }
        }

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPassword.Checked == true)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
               
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegisterNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formRegister log = new formRegister();
            log.ShowDialog();
        }

        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
