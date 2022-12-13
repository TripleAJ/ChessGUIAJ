using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChessBoardModel.BoardClass;

namespace ChessGameGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Board board = new Board();

            // Get the square at row 3 and column 4
            Square square = board.Squares[3, 4];

            // Check if the square is occupied
            if (square.IsOccupied)
            {
                // Get the chess piece on the square
               // ChessPiece piece = square.Piece;
            }
        }
    }
}
