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
    public partial class formViewOd : Form
    {
        public formViewOd()
        {
            InitializeComponent();
            loadOdData();
        }

        private void loadOdData()
        {
            iBankingEntities ibs = new iBankingEntities();
            var odData = ibs.tblOverDrafts.ToList();
            gvOverdraft.DataSource = odData;

        }
    }
}
