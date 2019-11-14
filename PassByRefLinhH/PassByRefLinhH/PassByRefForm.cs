/*
 * Created by: Linh Ho
 * Created on: November 14th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Pass by Reference
 * This program changes to different images when the user clicks on the picture box.
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

namespace PassByRefLinhH
{
    public partial class frmPassByRef : Form
    {
        // declare global variables
        Random randomNumberGenerator = new Random();
        public frmPassByRef()
        {
            InitializeComponent();
        }

        // Procedure: ChangeCard
        // Input: ref PictureBox aPictureBox, int cardNumber
        // Output: void
        // Description: This procedure takes a picture box passed by reference and a card number.
        // It assigns the imagage in the picture box to the card with the given card number.
        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources._2C;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources._3S;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources._4S;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources._5S;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources._6C;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources._7H;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources._8C;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.AC;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.AC;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
        }
        private void PicCard_Click(object sender, EventArgs e)
        {
            // declare local constants
            const int MAX_NUM_CARDS = 13;

            // declare local variables
            int aRandomNumber;
            
            // get a random number between 1 and the maximum
            aRandomNumber = randomNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            // get the card depending on the random seleciton
            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}
