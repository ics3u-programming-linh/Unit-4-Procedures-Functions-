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

        }

        private double CalculateHypotenuse (double opposite, double adjacent)
        {
            // declare variables
            double hypotenuse;

            // calculate the hypotenuse
            hypotenuse = Math.Sqrt(opposite + adjacent)
        }
        private void BtnCalculateHypotenuse_Click(object sender, EventArgs e)
        {

        }
    }
}
