/*
 * Created by:Linh Ho
 * Created on: November 6th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Pass by Temp
 * This program...uses user's input of celcius then converts it to a fahrenheit for temperature.
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

namespace PassByValueLinhHo
{
    public partial class frmPassByValue : Form
    {
        public frmPassByValue()
        {
            InitializeComponent();
        }

        // Function: CalculateFahrenheit
        // Input: double celsius, double fahrenheit
        // Output: void 
        // Description: This function takes the user's celsius passed by value
        // and displays a message box with the calculation of the fahrenheit
        public void CalculateFahrenheit(int celsius)
        {
            // declare local variables
            int celcius;
            double fahrenheit;

            // convert celcius to an integer
            celcius = int.Parse(txtCelsius.Text);

            // Calculate the fahrenheit
            fahrenheit = (double) 9 / (double) 5 * celsius + 32;

            // display a message box with the calculated fahrenheit
            MessageBox.Show(" The degrees in fahrenheit is: " + fahrenheit + "°");
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userCelsius;

            // convert the input celsius from String to int and assign them to their corresponding variables
            userCelsius = Convert.ToInt16(this.txtCelsius.Text);

            // Call the function to calculate the celsius passing the celsius and fahrenheit arguements by value
            this.CalculateFahrenheit(userCelsius);
        }
    }
}
