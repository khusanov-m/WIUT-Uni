using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class button : Form
    {
        public button()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = tbx_name.Text;
            decimal deposit = num_deposit.Value;
            decimal interest = num_interest.Value;
            decimal result = deposit + (deposit * interest / 100);

            MessageBox.Show("Hello, " + name + "\n" + "\n" + "Your deposit is " + deposit + " and your interest rate is " + interest 
                + ". As a result, your overall amount is " + result + ".");
        }
    }
}
