//-----------------------------------
// Ben Powers
// Assignment 2
// Game Design
// Student Number 7986250
// Sunday, November 4th, 2018
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
using System.IO;

namespace BPowersAssignment1
{
    public partial class Play : Form
    {
        int[,] gridArray; 
        Tiles[,] tiles;
        int boxMove = 0;

        string gameLoad = "";
        int numberOfBoxMoves = 0;
        int scoreCounter = 0;

        Tiles correctMovingTiles;

        int row;
        int col;

        public Play()
        {
            InitializeComponent();
        }

        // loads file that was saved on design form
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            gameLoad = openFileDialog1.FileName; 

            List<string> allValues = new List<string>();

            using (StreamReader sr = File.OpenText(gameLoad))
            {
                while (!sr.EndOfStream)
                {
                    string markString = sr.ReadLine();

                    if (markString != "")
                    {
                        allValues.Add(markString);
                    }
                }
            }

            gridArray = new int[allValues.Count, allValues[0].Length];
            tiles = new Tiles[allValues.Count, allValues[0].Length];

            for (int i = 0; i < allValues.Count; i++)
            {
                for (int j = 0; j < allValues[0].Length; j++)
                {
                    gridArray[i, j] = Convert.ToInt16(allValues[i].Substring(j, 1));

                    tiles[i, j] = new Tiles(i, j); 

                    if (gridArray[i, j] == 0) 
                    {
                        tiles[i, j].Image = null;
                        tiles[i, j].TileType = TileType.None;
                    }
                    else if (gridArray[i, j] == 1) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.wall;
                        tiles[i, j].TileType = TileType.Wall;
                    }
                    else if (gridArray[i, j] == 2) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.doorRed;
                        tiles[i, j].TileType = TileType.RedDoor;
                        tiles[i, j].Tag = "r";
                    }
                    else if (gridArray[i, j] == 3) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.doorGreen;
                        tiles[i, j].TileType = TileType.GreenDoor;
                        tiles[i, j].Tag = "g";
                    }
                    else if (gridArray[i, j] == 4) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.doorBlue;
                        tiles[i, j].TileType = TileType.BlueDoor;
                        tiles[i, j].Tag = "b";
                    }
                    else if (gridArray[i, j] == 5) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.doorYellow;
                        tiles[i, j].TileType = TileType.YellowDoor;
                        tiles[i, j].Tag = "y";
                    }
                    else if (gridArray[i, j] == 6) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.boxRed;
                        tiles[i, j].TileType = TileType.RedBox;
                        tiles[i, j].Tag = "r";
                        boxMove++;
                    }
                    else if (gridArray[i, j] == 7) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.boxGreen;
                        tiles[i, j].TileType = TileType.GreenBox;
                        tiles[i, j].Tag = "g";
                        boxMove++;
                    }
                    else if (gridArray[i, j] == 8) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.boxBlue;
                        tiles[i, j].TileType = TileType.BlueBox;
                        tiles[i, j].Tag = "b";
                        boxMove++;
                    }
                    else if (gridArray[i, j] == 9) 
                    {
                        tiles[i, j].Image = BPowersAssignment1.Properties.Resources.boxYellow;
                        tiles[i, j].TileType = TileType.YellowBox;
                        tiles[i, j].Tag = "y";
                        boxMove++;
                    }
                    tiles[i, j].Click += selectedTile;
                    this.Controls.Add(tiles[i, j]);
                }
            }  
        }

        // Records how many times the boxes move before finishing the level and displaying Success message
        private void RecordMoves()
        {
            numberOfBoxMoves = numberOfBoxMoves + 1;
            numberOfMovesLbl.Text = numberOfBoxMoves.ToString();
            if (boxMove == 0)
            {
                MessageBox.Show("WINNER WINNER CHICKEN DINNER");
            }
        }

        // Selecting a tile 
        public void selectedTile(object sender, EventArgs e) // select tile to move
        {
            correctMovingTiles = sender as Tiles;

            row = correctMovingTiles.Row; //row & col to locate the clicking picturebox
            col = correctMovingTiles.Col;

            if (tiles[row, col].TileType == TileType.RedBox ||
               tiles[row, col].TileType == TileType.GreenBox ||
               tiles[row, col].TileType == TileType.BlueBox ||
               tiles[row, col].TileType == TileType.YellowBox)
            {
                correctMovingTiles.BringToFront();
                upButton.Enabled = true;
                downButton.Enabled = true;
                leftButton.Enabled = true;
                rightButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Only the boxs with an X can be moved");
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = col;

                while (tiles[row, i - 1].Image == null)
                {
                    tiles[row, i - 1].Image = tiles[row, i].Image;
                    tiles[row, i].Image = null;

                    tiles[row, i - 1].Tag = tiles[row, i].Tag;
                    tiles[row, i].Tag = null;

                    i--;
                }
                if (tiles[row, i - 1].Tag == tiles[row, i].Tag)
                {
                    tiles[row, i].Image = null;

                    scoreCounter = scoreCounter + 100;
                    labelScore.Text = scoreCounter.ToString();

                    boxMove--;
                }

                col = i;

                RecordMoves();
            }
            catch
            {
                MessageBox.Show("Please Select a box before moving");
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = col;
                while (tiles[row, i + 1].Image == null)
                {
                    tiles[row, i + 1].Image = tiles[row, i].Image;
                    tiles[row, i].Image = null;

                    tiles[row, i + 1].Tag = tiles[row, i].Tag;
                    tiles[row, i].Tag = null;

                    i++;
                }
                if (tiles[row, i + 1].Tag == tiles[row, i].Tag)
                {
                    tiles[row, i].Image = null;
                    scoreCounter = scoreCounter + 100;
                    labelScore.Text = scoreCounter.ToString();

                    boxMove--;
                }

                col = i;

                RecordMoves();
            }
            catch
            {
                MessageBox.Show("Please Select a box before moving");
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            try
            {
                int j = row;
                while (tiles[j - 1, col].Image == null)
                {
                    tiles[j - 1, col].Image = tiles[j, col].Image;
                    tiles[j, col].Image = null;

                    tiles[j - 1, col].Tag = tiles[j, col].Tag;
                    tiles[j, col].Tag = null;
                    j--;
                }
                if (tiles[j - 1, col].Tag == tiles[j, col].Tag)
                {
                    tiles[j, col].Image = null;
                    scoreCounter = scoreCounter + 100;
                    labelScore.Text = scoreCounter.ToString();

                    boxMove--;
                }

                row = j;

                RecordMoves();
            }
            catch
            {
                MessageBox.Show("Please Select a box before moving");
            }

        }

        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                int j = row;
                while (tiles[j + 1, col].Image == null)
                {
                    tiles[j + 1, col].Image = tiles[j, col].Image;
                    tiles[j, col].Image = null;

                    tiles[j + 1, col].Tag = tiles[j, col].Tag;
                    tiles[j, col].Tag = null;

                    j++;
                }
                if (tiles[j + 1, col].Tag == tiles[j, col].Tag)
                {
                    tiles[j, col].Image = null;
                    scoreCounter = scoreCounter + 100;
                    labelScore.Text = scoreCounter.ToString();

                    boxMove--;
                }

                row = j;

                RecordMoves();
            }
            catch
            {
                MessageBox.Show("Please Select a box before moving");
            }
        }
    }
}
