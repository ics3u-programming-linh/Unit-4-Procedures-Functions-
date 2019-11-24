/*
 * Created by: Linh Ho
 * Created on: November 24th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if two strings are equal to each other or not.
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

namespace StringEqualityLinhHo
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();

            // Hide label
            lblAnswer.Hide();
        }

        private bool StringsAreEqual(string stringOne, string stringTwo)
        {
            // Declare local variables
            bool isEqual = false;

           // Make the strings uppercase
           stringOne = stringOne.ToUpper();
           stringTwo = stringTwo.ToUpper();

           // If strings are equal still, set isEqual to true
           if (stringOne == stringTwo)
           {
                isEqual = true;
           }
           else
           {
                isEqual = false;
           }

            // return bool
            return isEqual;

        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // Declare variables
            bool isEqual;
            string uString1, uString2;

            // Get the string from the user
            uString1 = txtString1.Text;
            uString2 = txtString2.Text;

            // Call function
            isEqual = StringsAreEqual(uString1, uString2);

            // Display true or false answer, depending on the returned isEqual answer
            if (isEqual == true)
            {
                lblAnswer.Text = "The strings are equal";
            }
            else
            {
                lblAnswer.Text = "The strings are not equal";
            }

            // Show label
            lblAnswer.Show();
        }
    }
}
