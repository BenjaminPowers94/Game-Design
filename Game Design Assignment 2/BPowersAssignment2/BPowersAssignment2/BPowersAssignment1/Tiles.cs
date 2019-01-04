//-----------------------------------
// Ben Powers
// Assignment 2
// Game Design
// Student Number 7986250
// Sunday, November 4th, 2018
//-----------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPowersAssignment1
{
    public enum TileType
    {
        None,
        Wall,
        RedDoor,
        GreenDoor,
        BlueDoor,
        YellowDoor,
        RedBox,
        GreenBox,
        BlueBox,
        YellowBox
    }

    class Tiles : PictureBox
    {
        const int STARTX = 180; //STARTING LOCATION for x axis row
        const int STARTY = 95; //STARTING LOCATION for y axis row

        const int GRIDWIDTH = 32; // BUTTON WIDTH
        const int GRIDHEIGHT = 32; // BUTTON HEIGHT

        const int BUTTONGAP = 34; // GAP BETWEEN BUTTONS

        private int row;
        private int col;
        private TileType tileType;

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public TileType TileType { get => tileType; set => tileType = value; }

        public Tiles(int row, int col)
        {
            int currentX = STARTX + col * BUTTONGAP;
            int currentY = STARTY + row * BUTTONGAP;

            this.Height = GRIDWIDTH;
            this.Width = GRIDHEIGHT;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Row = row;
            this.Col = col;
            this.TileType = TileType.None;
            this.Left = currentX;
            this.Top = currentY;
            this.Width = GRIDWIDTH;
            this.Height = GRIDHEIGHT;
            this.Name = "Button#" + row + col;
            this.Text = "button";

            Console.WriteLine($"[{row},{col}]start {currentX},{currentY}");
        }
    }
}