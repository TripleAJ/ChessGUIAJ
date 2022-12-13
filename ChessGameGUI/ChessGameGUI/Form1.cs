using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameGUI
{
    public partial class Form1 : Form
    {
        // referense thi to class BoardClass 
        static BoardClass myBoard = new BoardClass(8);
        // 2D array of button whos values are determined by myBoard
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            // create buttons and place them into panel1 with its size 
            int buttonSize = panel1.Width / myBoard.Size;


            // this make the panel square perfect size
            panel1.Height = panel1.Width;

            // nested loop to creat buttons and print them.
            for(int i=0; i < myBoard.Size;i++)
            {
                for(int j=0;j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    // add a click event to the button in the panel1
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add the new button to the panel

                    panel1.Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and colum of each number of the button we click 
            Button clickedButton = (Button)sender;
            Point loaction = (Point) clickedButton.Tag;

            int x = loaction.X;
            int y = loaction.Y;

            Cell currentCell = myBoard.theGride[x, y];
            // determin if its legal move 

            // upadte the text on each button 
            for(int i =0; i <myBoard.Size; i++)
            {
                for(int j =0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (myBoard.theGride[i,j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "legal";
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (myBoard.theGride[i,j].CurrentOccupided == true)
                    {
                        btnGrid[i, j].Text = "Knight";
                    }
                  
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
