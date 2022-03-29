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
    public partial class SocialWorkerListForm : Form
    {
        public SocialWorkerListForm()
        {
            InitializeComponent();
        }

        private void SocialWorkerListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvSocialWorker.DataMember = "";
            dgvSocialWorker.DataSource = null;
            dgvSocialWorker.DataSource = new SocialWorkerList().GetSocialWorkers();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.Hour;
                else
                    selectedAttribute = ByAttribute.Region;
                
                dgvSocialWorker.DataMember = "";
                dgvSocialWorker.DataSource = null;
                dgvSocialWorker.DataSource = new SocialWorkerList().SortLinq(selectedAttribute);
        }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("You forgot to provide the search term");
            else
            {
                var selectedAttribute = cbxSearch.SelectedIndex == 0 ? ByAttribute.Id :
                ByAttribute.Name;
                dgvSocialWorker.DataMember = "";
                dgvSocialWorker.DataSource = null;
                dgvSocialWorker.DataSource = new SocialWorkerList().Search(tbxSearch.Text, selectedAttribute);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new SocialWorkerEditForm().CreateNewSocialWorker();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSocialWorker.SelectedRows.Count == 0)
                MessageBox.Show("Please, select the employee to edit");
            else
            {
                var c = (SocialWorker)dgvSocialWorker.SelectedRows[0].DataBoundItem;
                new SocialWorkerEditForm().UpdateSocialworker(c);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSocialWorker.SelectedRows.Count == 0)
                MessageBox.Show("Please, choose the employee to delete");
            else
            {
                if (MessageBox.Show("Do you really want to fire this worker?", "Worker Firing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var c = (SocialWorker)dgvSocialWorker.SelectedRows[0].DataBoundItem;
                    new SocialWorkerManager().Delete(c.Id);
                    LoadData();
                }                
            }
        }
    }
}
