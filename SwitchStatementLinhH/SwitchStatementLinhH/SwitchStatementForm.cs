/*
 * Created by: Linh Ho
 * Created on: November 14th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program...gets a grade level from the user and displays a message box that shows a percentage, otherwise it will ask the user to enter a valid grade level.
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

namespace SwitchStatementLinhH
{
    public partial class frmSwitchStatement : Form
    {
        public frmSwitchStatement()
        {
            InitializeComponent();
        }

        private int ConvertToPercent(String level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            return percentage;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            string gradeLevel, userPercentage;
            
            // Get the grade level from user
            gradeLevel = txtGradeLevel.Text;           

            // Call function and get the percentage
            userPercentage = Convert.ToString(ConvertToPercent(gradeLevel));

            // Display a percentage with a message box
            MessageBox.Show("Your percentage is: " + userPercentage + "%");
        }
    }
}
