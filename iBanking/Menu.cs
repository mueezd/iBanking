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
            Mode depoForm = new Mode();
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
            this.Hide();
            Login_form log = new Login_form();
            log.ShowDialog();
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

        private void viewStatementsTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPayeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPayee aP = new addPayee();
            aP.MdiParent = this;
            aP.Show();
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makePayment mP = new makePayment();
            mP.MdiParent = this;
            mP.Show();
        }

        private void viewBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBalance vB = new viewBalance();
            vB.MdiParent = this;
            vB.Show();
        }

        private void viewStatementTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTransactions vB = new viewTransactions();
            vB.MdiParent = this;
            vB.Show();
        }

        private void transferToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            transferForm vB = new transferForm();
            vB.MdiParent = this;
            vB.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(userClass.userRole == 1)
            {
                consumerToolStripMenuItem.Visible = false;
            }
            else if(userClass.userRole == 2)
            {
                newAccountToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible = false;
                vIewToolStripMenuItem.Visible = false;
                overDraftODToolStripMenuItem.Visible = false;
            }
        }

        private void createOverDraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCreateOD cOD = new formCreateOD();
            cOD.MdiParent = this; ;
            cOD.Show();

        }

        private void addInterestThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAddInterest addInt = new formAddInterest();
            addInt.MdiParent = this;
            addInt.Show();  

        }

        private void processInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProcessInterest proInt = new formProcessInterest();
            proInt.MdiParent = this;
            proInt.Show(); 
        }

        private void allCustomersToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            allCustomers aC = new allCustomers();
            aC.MdiParent = this;
            aC.Show();
        }

        private void receivedInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receivedInterestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formConsumerInterest cI = new formConsumerInterest();
            cI.MdiParent = this;
            cI.Show();
        }

        private void viewInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewOverDraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formViewOd odF = new formViewOd();
            odF.MdiParent = this;
            odF.Show();
        }
    }
}
