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

        private double CalculateHypotenuse (double opposite, double adjacent)
        {
            // declare variables
            double hypotenuse;

            // calculate the hypotenuse
            hypotenuse = Math.Sqrt(Math.Pow(opposite, 2) + Math.Pow(adjacent, 2));

            return hypotenuse;
        }
        private void BtnCalculateHypotenuse_Click(object sender, EventArgs e)
        {
            // declare variables
            double userOpposite, userAdjacent, userHypotenuse;

            // get the balue from the user of opposite and adjacent
            userAdjacent = Convert.ToDouble(this.txtAdjacent);
            userOpposite = Convert.ToDouble(this.txtOpposite);

            // show the hypotenuse label
            lblHypotenuse.Show();

            // call the function to return the hypotenuse
            userHypotenuse = CalculateHypotenuse(userOpposite, userAdjacent);

            // Display the hypotenuse
            this.lblHypotenuse.Text = "The hypotenuse of the right angle is:" + userHypotenuse;
        }
    }
}
