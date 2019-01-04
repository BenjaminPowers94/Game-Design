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

namespace BPowersAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void designButton_Click(object sender, EventArgs e)
        {
            var design = new Design();
            design.ShowDialog(this);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var play = new Play();
            play.ShowDialog(this);
        }
    }
}
