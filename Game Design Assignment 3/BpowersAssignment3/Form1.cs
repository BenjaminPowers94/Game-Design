//-----------------------------------
// Ben Powers
// Assignment 3 (Tic Tac Toe)
// Game Design
// Student Number 7986250
// December 2nd 2018
//-----------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BpowersAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int players = 2;
        public int turns = 0;
        public int x1 = 0;
        public int o2 = 0;
        public int tie = 0;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //if(button.Text == "")
            if(button.BackgroundImage == null )
            {
                if (players % 2 == 0)
                {
                    button.Text = "X";
                    button.BackgroundImage = Properties.Resources.ximage;
                    players++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    button.BackgroundImage = Properties.Resources.oimage;
                    players++;
                    turns++;
                }
                if (CheckForTieGame() == true)
                {
                    MessageBox.Show("Tie game");
                    tie++;
                    NewGame();
                }
                if (CheckWinner() == true)
                {
                    if(button.Text == "X")
                    //if(button.BackgroundImage == Properties.Resources.ximage)
                    {
                        MessageBox.Show("X Won");
                        x1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won");
                        o2++;
                        NewGame();
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xWinLbl.Text = "X: " + x1;
            oWinLbl.Text = "O: " + o2;
            drawLbl.Text = "Draws: " + tie;
        }

        void NewGame()
        {
            players = 2;
            turns = 0;
            topLeftBtn.Text = topMiddleBtn.Text = topRightBtn.Text = middleLeftBtn.Text = middleMiddleBtn.Text = middleRightBtn.Text = bottomLeftBtn.Text = bottomMiddleBtn.Text = bottomRightBtn.Text = "";
            topLeftBtn.BackgroundImage = topMiddleBtn.BackgroundImage = topRightBtn.BackgroundImage = middleLeftBtn.BackgroundImage = middleMiddleBtn.BackgroundImage = middleRightBtn.BackgroundImage = bottomLeftBtn.BackgroundImage = bottomMiddleBtn.BackgroundImage = bottomRightBtn.BackgroundImage = null;
            xWinLbl.Text = "X: " + x1;
            oWinLbl.Text = "O: " + o2;
            drawLbl.Text = "Draws: " + tie;
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckForTieGame()
        {
            if ((turns == 9) &&CheckWinner()==false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool CheckWinner()
        {
            // horizontal checks
            if((topLeftBtn.Text == topMiddleBtn.Text) && (topMiddleBtn.Text == topRightBtn.Text) && topLeftBtn.Text != "") 
            {
                return true;
            }
            else if ((middleLeftBtn.Text == middleMiddleBtn.Text) && (middleMiddleBtn.Text == middleRightBtn.Text) && middleLeftBtn.Text != "") 
            {
                return true;
            }
            else if((bottomLeftBtn.Text == bottomMiddleBtn.Text) && (bottomMiddleBtn.Text == bottomRightBtn.Text) && bottomLeftBtn.Text != "") 
            {
                return true;
            }

            // vertical checks 
            if ((topLeftBtn.Text == middleLeftBtn.Text) && (middleLeftBtn.Text == bottomLeftBtn.Text) && topLeftBtn.Text != "") 
            {
                return true;
            }
            else if ((topMiddleBtn.Text == middleMiddleBtn.Text) && (middleMiddleBtn.Text == bottomMiddleBtn.Text) && topMiddleBtn.Text != "") 
            {
                return true;
            }
            else if ((topRightBtn.Text == middleRightBtn.Text) && (middleRightBtn.Text == bottomRightBtn.Text) && topRightBtn.Text != "") 
            {
                return true;
            }

            // diagnol checks 
            if ((topLeftBtn.Text == middleMiddleBtn.Text) && (middleMiddleBtn.Text == bottomRightBtn.Text) && topLeftBtn.Text != "") 
            {
                return true;
            }
            else if ((topRightBtn.Text == middleMiddleBtn.Text) && (middleMiddleBtn.Text == bottomLeftBtn.Text) && topRightBtn.Text != "") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            x1 = o2 = tie = 0;
            NewGame();
        }
    }
}
