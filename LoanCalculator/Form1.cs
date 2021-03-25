using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.05m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // assign new values to the variables
            //try 
            //{ 
            //    loan_amount = decimal.Parse(txt_LoanAmount.Text);
            //    number_of_months = int.Parse(txt_numberOfMonths.Text);
            //    interest_rate = decimal.Parse(txt_interestRate.Text);
            //}
            //catch 
            //{ 
            //    MessageBox.Show("Please add numbers only"); 
            //}

            if (decimal.TryParse(txt_LoanAmount.Text, out loan_amount))
            {
                if(int.TryParse(txt_numberOfMonths.Text, out number_of_months))
                {
                    if(decimal.TryParse(txt_interestRate.Text, out interest_rate))
                    {
                        //calculate loan
                        int counter = 0;
                        while (counter < number_of_months)
                        {
                            loan_amount = loan_amount + loan_amount * interest_rate;
                            listBox1.Items.Add("At month " + counter + " the loan is " + loan_amount.ToString("c"));
                            counter = counter + 1;
                        }
                        //done with while loop
                        txt_finalValue.Text = loan_amount.ToString("c");
                    }
                }
            }
            
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_LoanAmount.Text = "";
            txt_numberOfMonths.Text = "";
            txt_interestRate.Text = "";
            txt_finalValue.Text = "";
            listBox1.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
