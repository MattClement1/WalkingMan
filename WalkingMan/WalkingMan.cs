/*
*Created by: Matthew Clement
*Created on: 08-Oct-2015
*Created for: Unit #3-07
*This program displays an animated man walking
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
using System.Threading;

namespace WalkingMan
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            int loopCounter = 0;

            do
            {
                if (loopCounter == 0)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk2;
                }
                else if (loopCounter == 1)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk3;
                }
                else if (loopCounter == 2)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk4;
                }
                else if (loopCounter == 3)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk5;
                }
                else if (loopCounter == 4)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk6;
                }
                else if (loopCounter == 5)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk7;
                }
                else if (loopCounter == 6)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk8;
                }
                else if (loopCounter == 7)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk9;
                }
                else if (loopCounter == 8)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk10;
                }
                else if (loopCounter == 9)
                {
                    this.picWalkingMan.Image = WalkingMan.Properties.Resources.walk1;
                }

                loopCounter++;

                this.Refresh();
                Thread.Sleep(100);

            } while (loopCounter < 10);                       
        }
    }
}
