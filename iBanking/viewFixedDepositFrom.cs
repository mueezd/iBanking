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
    public partial class viewFixedDepositFrom : Form
    {
        BindingList<FixedDeposit> bl;
        iBankingEntities ibs;
        public viewFixedDepositFrom()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                bl = new BindingList<FixedDeposit>();
                ibs = new iBankingEntities();
                var date = dateTimePicker1.Value;
                //MessageBox.Show(date);

                var item = ibs.FixedDeposits
                    .Where(a => a.StartDate.Value == date.Date).ToList();

                dataGridViewViewFd.DataSource = item;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
