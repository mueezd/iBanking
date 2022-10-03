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
    public partial class changePasswordForm : Form
    {
        public changePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            iBankingEntities ibs = new iBankingEntities();

            if (textBoxOldPassword.Text != String.Empty || textBoxNewPassword.Text != String.Empty
                || textBoxConfirmPassword.Text == String.Empty)
            {
                tblUser user1 = ibs.tblUsers.FirstOrDefault(a => a.UserName.Equals(textBoxUserName.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(textBoxOldPassword.Text))
                    {
                        user1.Password = textBoxNewPassword.Text;
                        ibs.SaveChanges();
                        MessageBox.Show("Password Changed Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
            }
        }
    }
}
