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
        // Input: double userCelsius
        // Output: void 
        // Description: This function takes the user's celsius passed by value
        // and displays a message box with the calculation of the fahrenheit

        public void CalculateFahrenheit(double celsius, double fahrenheit)
        {
            // declare local variables
            double userCelsius;
            double fahrenheit;

            // display a message box with the calculated fahrenheit
            Message.Show("The fahrenheit degrees is" + fahrenheit);
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
