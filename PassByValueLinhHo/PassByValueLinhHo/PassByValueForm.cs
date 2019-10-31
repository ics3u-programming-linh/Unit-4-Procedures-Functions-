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
        public void CalculateFahrenheit(double celsius, double fahrenheit)
        {
            // declare local variables
            double fahrenheit;

            // Calculate the fahrenheit
            fahrenheit = (double)9 / (double)5 * celsius + 32;

            // display a message box with the calculated fahrenheit
            MessageBox.Show(" The degrees in fahrenheit is: " + fahrenheit);
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double celsius;
            double fahrenheit;

            // get user's input in celsius

            // convert the input length and width from String to int and assign
            // them to their corresponding variables

            celsius = Convert.ToInt32(this.txtCelsius.Text);

            celsius = fahrenheit; 
            // Call the function to calculate the celsius passing the celsius and fahrenheit arguements by value
            this.CalculateFahrenheit(celsius, fahrenheit);
        }
    }
}
