using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*Project Number: 8
 * Date: 9 October 2010
 * Programmer Name: Tara Eicher
 * Program Description: This project calculates commission based on the user's input.
 */
namespace ChrisCars
{
    public partial class frmCommission : Form
    {
        public frmCommission()
        {
            InitializeComponent();
        }
//Calculate the commission.
        private void btnCalculate_Click(object sender, EventArgs e)
        {//Declare variables.
            string strPrice, strCost;
            decimal decPrice, decCost, decAnswer;
            const decimal decCOMM_RATE = .20m;      //commission rate 20%
            try
            {//Convert the price to numeric form.
                strPrice = txtBxPrice.Text;
                decPrice = decimal.Parse(strPrice);
                try
                {//Convert the cost to numeric form.
                    strCost = txtBxCost.Text;
                    decCost = decimal.Parse(strCost);
                    decAnswer = decCOMM_RATE * (decPrice - decCost);
                    lblAnswer.Text = decAnswer.ToString("C");
                }
                catch (FormatException)
                {//Display message box when incorrect cost is entered.
                    MessageBox.Show("Invalid input for Cost Value", "Error");
                    txtBxCost.Text = "";
                    txtBxCost.Focus();
                }
            }
            catch (FormatException)
            {//Display message box when incorrect price is entered.
                MessageBox.Show("Invalid input for Selling Price", "Error");
                txtBxPrice.Text = "";
                txtBxPrice.Focus();

            }
        }
//Clear all text boxes and set the focus to Name.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            txtBxPrice.Text = "";
            txtBxCost.Text = "";
            lblAnswer.Text = "";
            txtBxName.Focus();
        }
//Close and exit the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
