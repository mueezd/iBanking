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
                var user1 = db.AdminTables.FirstOrDefault(a => a.UserName.Equals(txtBoxUserName.Text));

                if (user1!=null)
                {
                    if (user1.Password.Equals(txtBoxPassword.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Null Value");
                }
            }
            else
            {
                MessageBox.Show("Please enter User Name and Password");
            }
        }
    }
}
