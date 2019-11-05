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
        public void PrintAddress(String aptNumber, String streetAddress, String city, String province, String postalCode)
        {
            // Display the address
            MessageBox.Show("Your address is:" + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            String aptNumber, streetAddress, city, province, postalCode;

            // get the info from text boxes
            aptNumber = this.txtAptNum.Text;
            streetAddress = this.txtAptNum.Text;
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

        }
    }
}
