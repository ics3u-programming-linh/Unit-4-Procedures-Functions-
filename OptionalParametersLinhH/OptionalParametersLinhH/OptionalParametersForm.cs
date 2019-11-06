/*
 * Created by: Linh Ho
 * Created on: November 5th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Parameters
 * This program... has 2 procedures with the same name (PrintAddress) but different parameters. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersLinhH
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        // Procedure: PrintAddress
        // Input: String aptNumber, String streetAddress, String city, String province, String postalCode
        // Output: void
        // Description: This procedure displays a message box with the given five parameters: 
        // aptNumber, streetAddress, city, province and postalCode
        public void PrintAddress(String aptNumber, String streetAddress, String city, String province, String postalCode)
        {
            // Display the address
            MessageBox.Show("Your address is:" + aptNumber + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        // Procedure: PrintAddress
        // Input: String streetAddress, String city, String province, String postalCode
        // Output: void
        // Description: This procedure displays a message box with the given four parameters: 
        // streetAddress, city, province and postalCode
        public void PrintAddress(String streetAddress, String city, String province, String postalCode)
        {
            // Display the address
            MessageBox.Show("Your address is:" + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            String userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode;

            // get the info from text boxes
            userAptNumber = this.txtAptNum.Text;
            userStreetAddress = this.txtStreetAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            // make sure if user enters streetAddress
            if (userStreetAddress == "")
            {
                // show a message box to enter street address
                MessageBox.Show("Please enter your street address.");
            }
            // make sure user enters a city
            else if (userCity == "")
            {
                // show a message to enter province
                MessageBox.Show("Please enter your province");
            }
            // make sure user enters a postal code
            else if (userPostalCode == "")
            {
                // show a message to enter postal code
                MessageBox.Show("Please enter your postal code");
            }
            // if the user does not enter aptNumber, call the procedure that accepts only 4 string parameters
            else if (userAptNumber == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            // if the user enters all of the information, call the procedure that accepts 5 string parameters
            else
            {
                PrintAddress(userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode);
            }

        }
    }
}
