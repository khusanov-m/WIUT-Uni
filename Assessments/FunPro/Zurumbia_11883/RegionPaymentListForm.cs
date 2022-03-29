using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zurumbia_11883.DAL;

namespace Zurumbia_11883
{
    public partial class RegionPaymentListForm : Form
    {
        public RegionPaymentListForm()
        {
            InitializeComponent();
        }
        public RegionPayment RegionPayment { get; set; }

        public void LoadData()
        {
            dvRegionPayment.DataMember = "";
            dvRegionPayment.DataSource = null;
            dvRegionPayment.DataSource = new SocialWorkerList().Search(numRegion.Value.ToString(), ByAttribute.Region);
        }

        private void RegionPaymentListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            RegionPayment = new RegionPayment();

            // choosing month and year only
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy/MM/01";
            dtpDate.ShowUpDown = true;
        }

        public decimal SalarayOfAllWorker()
        {
            decimal TotalToPay = 0;

            for (int i = 0; i < dvRegionPayment.Rows.Count; i++)
            {
                // Calculating salary of all the employees
                TotalToPay += Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[4].Value);
            }
            return TotalToPay;
        }


        public void btnLoad_Click(object sender, EventArgs e)
        {
                LoadData();

                // Calculating worked hours of all the employees
                
                for (int i = 0; i < dvRegionPayment.Rows.Count; i++)
                {
                    decimal TotalSalaryOfEachWorker = Convert.ToDecimal(Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[2].Value) * Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[3].Value));
                    dvRegionPayment.Rows[i].Cells[4].Value = TotalSalaryOfEachWorker;
                }


                decimal PaidPercent = 0;

                for (int i = 0; i < dvRegionPayment.Rows.Count; i++)
                {
                    // Calculating worked hours of all the employees
                    PaidPercent =  decimal.Round(numLimitHours.Value / SalarayOfAllWorker(), 2);
                    
                    // to avoid big numbers in paid because of the high payment limit
                    if (PaidPercent >=1) {
                        dvRegionPayment.Rows[i].Cells[5].Value = Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[4].Value);
                    }else
                    {
                        dvRegionPayment.Rows[i].Cells[5].Value = PaidPercent * Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[4].Value);
                    }

                    // to show the proper value for extra hours
                    if(Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[5].Value) >= Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[4].Value))
                    {
                        dvRegionPayment.Rows[i].Cells[6].Value = 0;
                    }
                    else
                    {
                        dvRegionPayment.Rows[i].Cells[6].Value = Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[4].Value) - Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[5].Value);
                    }
                }

                // show total paid hours in label

                lblTotalHoursPaid.Text = $"Total paid salaries: {TotalPaidSalary()}";
        }

        public decimal TotalPaidSalary()
        {
            if (numLimitHours.Value < SalarayOfAllWorker())
            {
                return numLimitHours.Value;
            }
            else
            {
                return SalarayOfAllWorker();
            }
        }

        public decimal CalculatingSalaryOfAllWorker()
        {
            decimal SalaryOfAllWorker = 0;
            for (int i = 0; i < dvRegionPayment.Rows.Count; i++)
            {
                SalaryOfAllWorker =+ Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[3].Value);
            }
            return SalaryOfAllWorker;
        }

        public void InsertingToRegionPaymentData()
        {
            RegionPayment.Date = Convert.ToDateTime(dtpDate.Value.AddDays(1));
            RegionPayment.Region = Convert.ToInt32(numRegion.Value);
            RegionPayment.Headcount = Convert.ToInt32(dvRegionPayment.Rows.Count);
            RegionPayment.Limit = Convert.ToInt32(numLimitHours.Value);
            RegionPayment.Paid = TotalPaidSalary();
        }


        public void btnSave_Click(object sender, EventArgs e)
        {
            InsertingToRegionPaymentData();
            var manager = new RegionPaymentManager();
            manager.Create(RegionPayment);

            UpdatingSocialWorkerData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdatingSocialWorkerData()
        {
            for (int i = 0; i < dvRegionPayment.Rows.Count; i++)
            {

                dvRegionPayment.Rows[i].Cells[3].Value = Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[6].Value) / 
                    Convert.ToDecimal(dvRegionPayment.Rows[i].Cells[3].Value);
                dvRegionPayment.Rows[i].Cells[4].Value = 0;
                dvRegionPayment.Rows[i].Cells[5].Value = 0;

                var c = (SocialWorker)dvRegionPayment.Rows[i].DataBoundItem;
                new SocialWorkerEditForm().UpdateSocialworkerAutomically(c);
            }
        }

    }
}
