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
    public partial class formCreateOD : Form
    {
        iBankingEntities iBs = new iBankingEntities();
        tblConsumerAccount cA = new tblConsumerAccount();
        public formCreateOD()
        {
            InitializeComponent();
            accountLoad();
            dateLoad();
        }
        private void dateLoad()
        {
            lblDateNow.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void accountLoad()
        {
            var AccNoData = iBs.tblConsumerAccounts.ToList();
            comboBoxAccountNo.DataSource = AccNoData;
            comboBoxAccountNo.DisplayMember = "AccountNo";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblOverDraft oD = new tblOverDraft();

            oD.AccountNo = Convert.ToInt32(comboBoxAccountNo.Text);
            oD.AccountName = cA.Name;
            oD.CreateDate = Convert.ToDateTime(lblDateNow.Text);
            oD.PeriodDate = dateTimePickerPeriod.Value;
            oD.OdAmount = Convert.ToDecimal(textBoxOdAmount.Text);

            iBs.tblOverDrafts.Add(oD);
            iBs.SaveChanges();
            MessageBox.Show("Over Draft Added Successfully");

        }
    }
}
