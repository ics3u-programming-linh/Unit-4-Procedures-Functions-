/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program has 2 procedures with the same name (PrintAddress) but different parameters.
 * User enters their information such as streetAddress, city, province and postal code. 
 * The program displays the following information as a message box.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersLinhH
{
    static class OptionalParameters
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOptionalParameters());
        }
    }
}
