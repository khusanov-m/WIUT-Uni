using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zurumbia_11883.DAL;

namespace Zurumbia_11883
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new AboutApp();
            form.ShowDialog();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AppVersion();
            form.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void allWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<SocialWorkerListForm>().Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<RegionPaymentListForm>().Show();
        }

        private void newWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SocialWorkerEditForm().CreateNewSocialWorker();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<RegionListForm>().Show();
        }
    }
}
