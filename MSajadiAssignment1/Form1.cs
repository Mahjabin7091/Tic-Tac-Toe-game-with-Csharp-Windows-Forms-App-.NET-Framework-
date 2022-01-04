/*Author: Mahjabin Sajadi
 * Purpose: Game
 * Date: 28-09-2021
 */

#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Initialize
        /**********************First player X*******************************/
        private bool playerOTurn = false;
        /**********************definition x/o images****************************/
        private Image x = Properties.Resources.X;
        private Image o = Properties.Resources.O;
        /*********************************Form Load*****************************/
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reset
        private void Reset()
        {
            pictureBox1.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox7.BackgroundImage = null;
            pictureBox8.BackgroundImage = null;
            pictureBox9.BackgroundImage = null;

            playerOTurn = false;
        }

        #endregion

        #region Check

        /******************Checking the win pattern for each player (x or o)***************************/
        private void Check()
        {

            if (pictureBox3.BackgroundImage == x)
            {
                if (pictureBox5.BackgroundImage == x)
                {
                    if (pictureBox7.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox4.BackgroundImage == x)
            {
                if (pictureBox5.BackgroundImage == x)
                {
                    if (pictureBox6.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox7.BackgroundImage == x)
            {
                if (pictureBox8.BackgroundImage == x)
                {
                    if (pictureBox9.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox2.BackgroundImage == x)
            {
                if (pictureBox5.BackgroundImage == x)
                {
                    if (pictureBox8.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox3.BackgroundImage == x)
            {
                if (pictureBox6.BackgroundImage == x)
                {
                    if (pictureBox9.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == x)
            {
                if (pictureBox2.BackgroundImage == x)
                {
                    if (pictureBox3.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == x)
            {
                if (pictureBox5.BackgroundImage == x)
                {
                    if (pictureBox9.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == x)
            {
                if (pictureBox4.BackgroundImage == x)
                {
                    if (pictureBox7.BackgroundImage == x)
                    {
                        MessageBox.Show("Player X won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == o)
            {
                if (pictureBox2.BackgroundImage == o)
                {
                    if (pictureBox3.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == o)
            {
                if (pictureBox5.BackgroundImage == o)
                {
                    if (pictureBox9.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage == o)
            {
                if (pictureBox4.BackgroundImage == o)
                {
                    if (pictureBox7.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox3.BackgroundImage == o)
            {
                if (pictureBox5.BackgroundImage == o)
                {
                    if (pictureBox7.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox4.BackgroundImage == o)
            {
                if (pictureBox5.BackgroundImage == o)
                {
                    if (pictureBox6.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox7.BackgroundImage == o)
            {
                if (pictureBox8.BackgroundImage == o)
                {
                    if (pictureBox9.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox2.BackgroundImage == o)
            {
                if (pictureBox5.BackgroundImage == o)
                {
                    if (pictureBox8.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox3.BackgroundImage == o)
            {
                if (pictureBox6.BackgroundImage == o)
                {
                    if (pictureBox9.BackgroundImage == o)
                    {
                        MessageBox.Show("Player O won!");
                        return;
                    }
                }
            }

            if (pictureBox1.BackgroundImage != null && pictureBox2.BackgroundImage != null && pictureBox3.BackgroundImage != null && pictureBox4.BackgroundImage != null && pictureBox5.BackgroundImage != null && pictureBox6.BackgroundImage != null && pictureBox7.BackgroundImage != null && pictureBox8.BackgroundImage != null && pictureBox9.BackgroundImage != null)
            {
                MessageBox.Show("It's a Tie!");
                return;
            }
        }

        #endregion

        #region PlaceClick
        private void PlaceClick(ref PictureBox ClickedPic)
        {

            if (ClickedPic.BackgroundImage == null)
            {
                if (playerOTurn == false)
                {
                    ClickedPic.BackgroundImage = x;
                    playerOTurn = true;
                    Check();
                }
                else
                {
                    ClickedPic.BackgroundImage = o;
                    playerOTurn = false;
                    Check();
                }
            }
            else
            {
                MessageBox.Show("The place is already chosen!");
            }

        }

        #endregion
 
        #region ButtonClicks
        /********New Game***********/
        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }
        /**********Close game**********/
        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        /**************picBox click******************/
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox1);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox2);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PlaceClick(ref pictureBox9);
        }
    }
}
