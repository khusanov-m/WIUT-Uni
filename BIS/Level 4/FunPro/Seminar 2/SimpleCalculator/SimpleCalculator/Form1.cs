using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            decimal operation = num_first.Value + num_second.Value;
            lbl_result.Text = "Your result: " + operation;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            decimal operation = num_first.Value - num_second.Value;
            lbl_result.Text = "Your result: " + operation;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            decimal operation = num_first.Value * num_second.Value;
            lbl_result.Text = "Your result: " + operation;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            decimal operation = num_first.Value / num_second.Value;
            lbl_result.Text = "Your result: " + operation;
        }

        private void btn_remainder_Click(object sender, EventArgs e)
        {
            decimal operation = num_first.Value % num_second.Value;
            lbl_result.Text = "Your result: " + operation;
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            decimal operation = (decimal)Math.Pow((double)num_first.Value, (double)num_second.Value);
            lbl_result.Text = "Your result: " + operation;
        }
    }
}
