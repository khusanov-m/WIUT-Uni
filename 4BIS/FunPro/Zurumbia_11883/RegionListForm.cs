using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zurumbia_11883.DAL;

namespace Zurumbia_11883
{
    public partial class RegionListForm : Form
    {
        public RegionListForm()
        {
            InitializeComponent();
        }

        private void RegionListForm_Load(object sender, EventArgs e)
        {
            dgvRegionList.DataMember = "";
            dgvRegionList.DataSource = null;
            dgvRegionList.DataSource = new RegionPaymentList().GetRegionPayments();
        }
    }
}
