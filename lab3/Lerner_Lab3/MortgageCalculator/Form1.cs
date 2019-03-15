using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class MortgageCal : Form
    {
        public MortgageCal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            //validates if number is entered into textbox
            double priceB;
            double.TryParse(priceBox.Text, out priceB);
            if(priceB == 0)
            {
                MessageBox.Show("Please enter only numbers");
                priceBox.BackColor = Color.Pink;
                return;               
            }        
        }
        private void downPayBox_TextChanged(object sender, EventArgs e)
        {
            //validates if number is entered into textbox
            double downPayB;
            double.TryParse(downPayBox.Text, out downPayB);
            if (downPayB == 0)
            {
                MessageBox.Show("Please enter only numbers");
                downPayBox.BackColor = Color.Pink;
                return;                
            }
        }
        private void interestBox_TextChanged(object sender, EventArgs e)
        {

            //validates if number is entered into textbox
            double interestB;
            double.TryParse(interestBox.Text, out interestB);
            if(interestB == 0 )
            {
                MessageBox.Show("Please enter only numbers ");
                interestBox.BackColor = Color.Pink;
                return;
            }
        }
        private void termBox_TextChanged(object sender, EventArgs e)
        {
            //validates if number is entered into textbox
            double termB;
            double.TryParse(termBox.Text, out termB);
            if (termB == 0)
            {
                MessageBox.Show("Please enter only numbers");
                termBox.BackColor = Color.Pink;
                return;
            }
        }
        //This is for the Click Button Event
        private void calculate_Click(object sender, EventArgs e)
        {
         //checks if the text block if left blank when user clicks on calculate  
            if (nameBox.Text == "")              
                {                
                nameBox.BackColor = Color.Pink;
                MessageBox.Show("The inputs on this form cannot be empty");
                }
            if (priceBox.Text == "")
                {
                priceBox.BackColor = Color.Pink;
                MessageBox.Show("The inputs on this form cannot be empty");
                }
            if (downPayBox.Text == "")
                {
                downPayBox.BackColor = Color.Pink;
                MessageBox.Show("The inputs on this form cannot be empty");
                }
            if (interestBox.Text == "")
                {
                interestBox.BackColor = Color.Pink;
                MessageBox.Show("The inputs on this form cannot be empty");
                }
            if (termBox.Text == "")
                {
                termBox.BackColor = Color.Pink;
                MessageBox.Show("The inputs on this form cannot be empty");
                }

            double price, downPay, numA, numP, topEQ, bottomEQ, term, interest;
            
            price = Convert.ToDouble(priceBox.Text);
            downPay =Convert.ToDouble(downPayBox.Text);
            numP = price - downPay;
            interest = (Convert.ToDouble(interestBox.Text)/100)/12;
            term = Convert.ToDouble(termBox.Text);
          

            topEQ = Math.Pow((1 + interest), term);
            bottomEQ = Math.Pow((1 + interest), term) - 1;
            numA = interest * numP * (topEQ / bottomEQ);



            financeBox.Text = numP.ToString("C2");
            paymentBox.Text = numA.ToString("C2");


        }
        //This Code is for Text Box Focus.  It allows the user to press enter and continue with input. 

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                priceBox.Focus();
            }
        }

        private void priceBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                downPayBox.Focus();
            }
        }

        private void downPayBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                interestBox.Focus();
            }
        }

        private void interestBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                termBox.Focus();
            }
        }

        private void termBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate.Focus();
            }
        }
    }
}