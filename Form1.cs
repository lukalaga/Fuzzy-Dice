using System;
using System.Windows.Forms;

namespace Number5
{
    public partial class Form1 : Form
    {
        double total;
        double subtotal;
        double taxcollecetd;
        const double tax = 0.05;
        const double shipping = 1.5;
        //Assuming the price of the dices are these
        const double blackdice = 6.25;
        const double reddice = 5;
        const double bluedice = 7.5;
        double blacktotal, redtotal, bluetotal, shipping_count;

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Eroor Messages + Input validation
            if (ChkBlack.Checked == false && ChkRed.Checked == false && ChkBlue.Checked == false)
            {
                MessageBox.Show("Please Choose A color Dice to Purchase");
            }
            else if (QtyBlack.Text == "" && ChkBlack.Checked == false)
            {
                MessageBox.Show("Enter Black Dice Quantity Amount to purchase", "Item not selected");
            }
            else if (QtyRed.Text == "" && ChkRed.Checked == false)
            {
                MessageBox.Show("Enter Red Dice Quantity Amount to purchase", "Item not selected");
            }
            else if (QtyBlue.Text == "" && ChkBlue.Checked == false)
            {
                MessageBox.Show("Enter Blue Dice Quantity Amount to purchase", "Item not selected");
            }

            //VALIDATE PANEL 1
            if (txtordernumber.Text == "")
            {
                MessageBox.Show("Enter Order Number");
            }
            //Billing inforamtion validation
            if (txtcustomername.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("Enter Billing Information", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //CALCULATE & validates if conditions met 
            //UPDATING SHIPPING COUNT
            //RED DICE
            if (QtyRed.Text != string.Empty && ChkRed.Checked == true)
            {
                redtotal = double.Parse(QtyRed.Text);
                subtotal = redtotal * reddice;
                label13.Text = subtotal.ToString();
                shipping_count += redtotal;
            }
            //BLUE DICE
            if (QtyBlue.Text != string.Empty && ChkBlue.Checked == true)
            {
                bluetotal = double.Parse(QtyBlue.Text);
                subtotal = bluetotal + (bluedice * bluetotal);
                label14.Text = subtotal.ToString();
                shipping_count += bluetotal;
            }
            //BLACK DICE
            if (QtyBlack.Text != string.Empty && ChkBlack.Checked == true)
            {
                blacktotal = double.Parse(QtyBlack.Text);
                subtotal += (blackdice * blacktotal);
                label15.Text = subtotal.ToString();
                shipping_count += blacktotal;
            }

            taxcollecetd = subtotal * tax;

            //DISPLAY 

            label16.Text = subtotal.ToString();
            label7.Text = taxcollecetd.ToString();

            //SHIPPING LOGIC
            if (shipping_count > 20)
            {
                label9.Text = Convert.ToString(0);
            }
            else
                label9.Text = shipping.ToString();
            subtotal = shipping + shipping;

            //TOTAL COST(money)
            total = subtotal + taxcollecetd;
            label10.Text = total.ToString();
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }          
        }
    }
}
            
