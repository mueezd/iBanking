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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newAccount newac = new newAccount();
            newac.MdiParent = this;
            newac.Show();

        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updationForm upForm = new updationForm();
            upForm.MdiParent = this;
            upForm.Show();
        }

        private void allCustomersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            allCustomers allCust = new allCustomers();
            allCust.MdiParent = this;
            allCust.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositForm depoForm = new depositForm();
            depoForm.MdiParent = this;
            depoForm.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawForm wdForm = new withdrawForm();
            wdForm.MdiParent = this;
            wdForm.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferForm transForm = new transferForm();
            transForm.MdiParent = this;
            transForm.Show();
        }

        private void fIxedDepositFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixedDepositForm fdForm = new fixedDepositForm();
            fdForm.MdiParent = this;
            fdForm.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceSheetForm bsForm = new balanceSheetForm();
            bsForm.MdiParent = this;
            bsForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordForm cpForm = new changePasswordForm();
            cpForm.MdiParent = this;
            cpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewFixedDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewFixedDepositFrom viewFDForm = new viewFixedDepositFrom();
            viewFDForm.MdiParent = this;
            viewFDForm.Show();  
        }
    }
}
