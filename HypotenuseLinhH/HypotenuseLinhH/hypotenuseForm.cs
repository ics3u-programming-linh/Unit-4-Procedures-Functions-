/*
 * Created by: Linh Ho
 * Created on: November 14th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Calculate Hypotenuse
 * This program calculates the hypotenuse using the given side of A and B from user.
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

namespace HypotenuseLinhH
{
    public partial class frmHypotenuse : Form
    {
        public frmHypotenuse()
        {
            InitializeComponent();
            // hide the hypotenuse label
            lblHypotenuse.Hide();
        }

        private double CalculateHypotenuse (double sideA, double sideB)
        {
            // declare variables
            double hypotenuse;

            // calculate the hypotenuse
            hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return hypotenuse;
        }
        private void BtnCalculateHypotenuse_Click(object sender, EventArgs e)
        {
            // declare variables
            double userB, userA, userHypotenuse;

            // get the value from the user of A and B
            userA = Convert.ToDouble(this.txtAdjacent.Text);
            userB = Convert.ToDouble(this.txtOpposite.Text);

            // show the hypotenuse label
            lblHypotenuse.Show();

            // call the function to return the hypotenuse
            userHypotenuse = CalculateHypotenuse(userA, userB);

            // Display the hypotenuse
            this.lblHypotenuse.Text = "The hypotenuse of the right angle is:" + userHypotenuse;
        }
    }
}
