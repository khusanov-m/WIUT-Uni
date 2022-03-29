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
    
    public partial class SocialWorkerEditForm : Form
    {
       
        public SocialWorkerEditForm()
        {
            InitializeComponent();

        }

        public Boolean isAutomically = false;
        
        public SocialWorker SocialWorker { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewSocialWorker()
        {
            isAutomically = false;
            Mode = FormMode.CreateNew;
            SocialWorker = new SocialWorker();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateSocialworker(SocialWorker socialWorker)
        {
            Mode = FormMode.Update;
            SocialWorker = socialWorker;
            ShowApplicantInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }
        
        // When user try to submit monthly data, this clear worked hours rows and update rows by extra hours
        public void UpdateSocialworkerAutomically(SocialWorker socialWorker)
        {
            isAutomically = true;
            Mode = FormMode.Update;
            SocialWorker = socialWorker;
            ShowApplicantInControls();
            Save();
        }

        private void ShowApplicantInControls()
        {
            tbxName.Text = SocialWorker.Name;
            numRegion.Value = SocialWorker.Region;
            tbxHours.Text = SocialWorker.Hours.ToString();
            tbxRate.Text = SocialWorker.Rate.ToString();
        }

        private void GrabUserInput()
        {
            SocialWorker.Name = tbxName.Text;
            SocialWorker.Region = Convert.ToInt32(numRegion.Value);
            SocialWorker.Hours = decimal.Parse(tbxHours.Text);
            SocialWorker.Rate = decimal.Parse(tbxRate.Text);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            try
            {
                GrabUserInput();
                var manager = new SocialWorkerManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(SocialWorker);
                else
                    manager.Update(SocialWorker);

                MyForms.GetForm<SocialWorkerListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SocialWorkerEditForm_Load(object sender, EventArgs e)
        {
            if(isAutomically)
            {
                Save();
            }else
            {
                MdiParent = MyForms.GetForm<ParentForm>();
            }
        }
    }
}
