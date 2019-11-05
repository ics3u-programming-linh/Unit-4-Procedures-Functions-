/*
 * Created by: Linh Ho
 * Created on: November 5th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Functions
 * This program calculates the volume of a cylinder
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

namespace FunctionsLinhH
{
    public partial class frmFunctions : Form
    {
        public frmFunctions()
        {
            InitializeComponent();

            // Hide labels
            lblVolume.Hide();
        }

        private double CalculateVolCyl (double height , double radius)
        {
            // declare variables
            double volume;

            // calculate the volume of a cyclinder
            volume = height * Math.Pow(radius, 2) * 3.14;

            return volume;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare variables 
            double userHeight, userRadius, userVolume;

            // get the value from the user of radius and height
            userHeight = Convert.ToDouble(this.txtHeight.Text);
            userRadius = Convert.ToDouble(this.txtRadius.Text);

            // call the function to return the volume
            userVolume = CalculateVolCyl(userHeight, userRadius);

            // Make the label visible
            lblVolume.Show();

            // Display the volume
            this.lblVolume.Text = "The volume of the cyclinder is: " + userVolume;

        }
    }
}
