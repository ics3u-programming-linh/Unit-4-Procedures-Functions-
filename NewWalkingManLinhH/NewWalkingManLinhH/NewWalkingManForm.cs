﻿/*
 * Created by: Linh Ho
 * Created on: November 22, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Dynamic Picture Box Creation & Click Events
 * This program...creates a picture box dynamically and moves when user clicks on an image
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
//Add system threading
using System.Threading;

namespace NewWalkingManLinhH
{
    public partial class frmNewWalkingMan : Form
    {
        public frmNewWalkingMan()
        {
            InitializeComponent();
            // hide the label
            lblInstructions.Hide();
        }

        private void FrmNewWalkingMan_Load(object sender, EventArgs e)
        {

        }
        private void GeneratePictureBoxes()
        {
            // generate each of the picture boxes on the form
            GeneratePictureBox(100, 50);
            GeneratePictureBox(464, 50);
            GeneratePictureBox(100, 250);
            GeneratePictureBox(464, 250);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            // reveal the instructions
            this.lblInstructions.Show();

            // generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture and a new point 
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // set the lcoation of the picture box
            tmpPicMan.Location = pntPic;

            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the picture box width and height to be the same
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener 
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // cast the sender object into a Picture Box
            PictureBox tmpPicMan = (PictureBox)sender;

            // write a message to the console to check which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X , + tmpPicMan.Location.Y + ") was clicked.");

            // declare local variables and constants
            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // continue this loop while the frame counter has not reached the max number of frames we have to display 
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                // Increment the counter
                pictureFrameCounter = pictureFrameCounter + 1;

                // refresh the form
                this.Refresh();

                // pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }
    }
}

