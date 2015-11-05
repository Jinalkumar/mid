/**
 * Name: Jinalkumar Patel
 * Date: 10/21/2015
 * Purpose: This is an Application for currency converter
 *          Basically It has 3 different kinds of currencies such as USD,CAD,EURO
 *          Application converts one currency to the tow others
 *          It needs user input in decimal to make a calculation
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm
{
    public partial class CurrencyConverter : Form
    {//This Provides the actual currency rates for all for Just '1'.
        const decimal CAD_AMOUNT_HAVE = 1;
        const decimal CAD_AMOUNT_WANT_EURO = 1.4662m;
        const decimal CAD_AMOUNT_WANT_USD = 1.3036m;
        const decimal USD_AMOUNT_WANT_CAD = 0.7671m;
        const decimal USD_AMOUNT_WANT_EURO = 1.1247m;
        const decimal EURO_AMOUNT_WANT_CAD = 0.6820m;
        const decimal EURO_AMOUNT_WANT_USD = 0.8891m;
       
        public CurrencyConverter()
        {
            InitializeComponent();
        }

      

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            //Default page would show conversion of cad to usd for just an example.
            CADIhaveRadioButton.Checked = true;
            USDIwantRadioButton.Checked = true;
            ExchangeFeeCheckBox.Checked = false;
            AmountIhaveTextBox.Text = CAD_AMOUNT_HAVE.ToString("F0");
            AmountIwantTextBox.Text = USD_AMOUNT_WANT_CAD.ToString("F4");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //This would reset the application to the default
            CADIhaveRadioButton.Checked = true;
            USDIwantRadioButton.Checked = true;
            ExchangeFeeCheckBox.Checked = false;
            AmountIhaveTextBox.Text = CAD_AMOUNT_HAVE.ToString("F0");
            AmountIwantTextBox.Text = USD_AMOUNT_WANT_CAD.ToString("F4");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Button would close the application window
            this.Close();
        }


        
        //it will show the calculation in amount want box on user's operations.
        //it will handle error exeptions and check all requirements of null and invalid entries.

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            decimal calculatedCAD = 0, calculatedUSD = 0, calculatedEURO = 0;
            decimal AmountIhave;

            try
            {
                AmountIhave = decimal.Parse(AmountIhaveTextBox.Text);
                if (AmountIhave > 0)
                {
                    //
                    if (CADIhaveRadioButton.Checked)
                    {
                        try
                        {
                            if (USDIwantRadioButton.Checked)
                            {
                                calculatedCAD = (AmountIhave * USD_AMOUNT_WANT_CAD);
                                AmountIwantTextBox.Text = calculatedCAD.ToString("F4");

                               
                            }
                            else if (EUROIwantRadioButton.Checked)
                            {
                                calculatedCAD = (AmountIhave * EURO_AMOUNT_WANT_CAD);
                                AmountIwantTextBox.Text = calculatedCAD.ToString("F4");
                                

                            }
                            else if (CADIwantRadioButton.Checked)//If You would select CAD in both section (have and want) then it will show error window
                            {
                                MessageBox.Show("That is an invalid option", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            }
                        catch (FormatException)//It will show you the right way
                            {
                                MessageBox.Show("Please select any other option from currency i want", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                    }
                    else if (USDIhaveRadioButton.Checked)
                    {
                        try
                        {
                            if (CADIwantRadioButton.Checked)
                            {
                                calculatedUSD = (AmountIhave * CAD_AMOUNT_WANT_USD);
                                AmountIwantTextBox.Text = calculatedUSD.ToString("F4");

                                
                            }
                            else if (EUROIwantRadioButton.Checked)
                            {
                                calculatedUSD = (AmountIhave * EURO_AMOUNT_WANT_USD);
                                AmountIwantTextBox.Text = calculatedUSD.ToString("F4");
                               

                            }
                            else if (USDIwantRadioButton.Checked)//If You would select Euro in both section (have and want), then it will show error window
                            {
                                MessageBox.Show("That is an invalid option", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            }
                        catch (FormatException)
                            {
                                MessageBox.Show("Please select any other option from currency i want", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                    }
                    else if (EUROIhaveRadioButton.Checked)
                    {
                        try
                        {
                            if (CADIwantRadioButton.Checked)
                            {
                                calculatedEURO = (AmountIhave * CAD_AMOUNT_WANT_EURO);
                                AmountIwantTextBox.Text = calculatedEURO.ToString("F4");

                            }
                            else if (USDIwantRadioButton.Checked)
                            {
                                calculatedEURO = (AmountIhave * USD_AMOUNT_WANT_EURO);
                                AmountIwantTextBox.Text = calculatedEURO.ToString("F4");
                               

                            }

                            else if (EUROIwantRadioButton.Checked)//If You would select Euro in both section (have and want) then it will show error window
                            {
                                MessageBox.Show("That is an invalid option", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            }
                        catch (FormatException)
                            {
                            MessageBox.Show("Please select any other option from currency i want", "imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                    }
                    else
                    {
                        MessageBox.Show("Please select any other option from currency i have", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
            }
            catch (FormatException)
            {
                if (AmountIhaveTextBox.Text == String.Empty)//If you press convert button with emptybox, you will get this error
                {
                    MessageBox.Show("Please enter amount you want to calclute '>0'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//If you press any thing else from keyboard except numbers, you will get this error 
                {
                    MessageBox.Show("Amount must be a whole number '>0'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

    }
}
