//-----------------------------------
// Ben Powers
// Assignment 1
// Game Design
// Student Number 7986250
// Sunday, September 30th, 2018
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
using System.Text.RegularExpressions;

namespace BPowersAssignment1
{
    public partial class Design : Form
    {
        private TileType toolTypes;
        int[,] buttonImagesArr; //each button's image index

        public Design()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRows = int.Parse(rowTxtBox.Text);

                int numberOfColumns = int.Parse(columnTxtBox.Text);

                buttonImagesArr = new int[numberOfRows, numberOfColumns];

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        Tiles b = new Tiles(i, j, TileType.None);
                        this.Controls.Add(b);
                        b.Click += wallClick;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Both Numbers for Row and Column!");
            }
        }

        public void wallClick(object sender, EventArgs e)
        {
            Tiles pb = (Tiles)sender;
            string rowColumn = Regex.Match(pb.Name, @"\d+").ToString(); // button index
            int row = (int)char.GetNumericValue(rowColumn[0]);
            int column = (int)char.GetNumericValue(rowColumn[1]);

            if (toolTypes == TileType.None)
            {
                pb.Image = Properties.Resources.none;
                buttonImagesArr[row, column] = 0;   // matching each button stores image index
            }
            else if (toolTypes == TileType.Wall)
            {
                pb.Image = Properties.Resources.wall;
                buttonImagesArr[row, column] = 1;
            }
            else if (toolTypes == TileType.RedDoor)
            {
                pb.Image = Properties.Resources.doorRed;
                buttonImagesArr[row, column] = 2;
            }
            else if (toolTypes == TileType.GreenDoor)
            {
                pb.Image = Properties.Resources.doorGreen;
                buttonImagesArr[row, column] = 3;
            }
            else if (toolTypes == TileType.BlueDoor)
            {
                pb.Image = Properties.Resources.doorBlue;
                buttonImagesArr[row, column] = 4;
            }
            else if (toolTypes == TileType.YellowDoor)
            {
                pb.Image = Properties.Resources.doorYellow;
                buttonImagesArr[row, column] = 5;
            }
            else if (toolTypes == TileType.RedBox)
            {
                pb.Image = Properties.Resources.boxRed;
                buttonImagesArr[row, column] = 6;
            }
            else if (toolTypes == TileType.GreenBox)
            {
                pb.Image = Properties.Resources.boxGreen;
                buttonImagesArr[row, column] = 7;
            }
            else if (toolTypes == TileType.BlueBox)
            {
                pb.Image = Properties.Resources.boxBlue;
                buttonImagesArr[row, column] = 8;
            }
            else
            {
                pb.Image = Properties.Resources.boxYellow;
                buttonImagesArr[row, column] = 9;
            }
        }

        private void wallButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.Wall;
        }

        private void redDoorButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.RedDoor;
        }

        private void greenDoorButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.GreenDoor;
        }

        private void blueDoorButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.BlueDoor;
        }

        private void yellowDoorButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.YellowDoor;
        }

        private void redBoxButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.RedBox;
        }

        private void greenBoxButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.GreenBox;
        }

        private void blueBoxButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.BlueBox;
        }

        private void yellowBoxButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.YellowBox;
        }

        private void noneButton_Click(object sender, EventArgs e)
        {
            toolTypes = TileType.None;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt) | *.txt";     // File type
            saveFileDialog1.Title = "Save";                // Dialog name
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    // iterates number of rows
                    for (int i = 0; i < buttonImagesArr.GetLength(0); i++)
                    {
                        string line = "";
                        // iterrates number of columns
                        for (int j = 0; j < buttonImagesArr.GetLength(1); j++)
                        {
                            line += buttonImagesArr[i, j];
                            if (j != buttonImagesArr.GetUpperBound(0))
                                line += ',';
                        }
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("SAVED");
            }
        }
    }
}
