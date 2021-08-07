using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(3);
            b.MarkCell(0, Mark.X);
            b.MarkCell(1, Mark.X);
            b.MarkCell(2, Mark.X);
            b.MarkCell(3, Mark.X);
            b.MarkCell(4, Mark.X);
            b.MarkCell(5, Mark.X);
            b.MarkCell(6, Mark.X);
            b.MarkCell(7, Mark.X);
            b.MarkCell(8, Mark.X);
            //b.MarkCell(9, Mark.X);
            //b.MarkCell(4, Mark.X);
            Console.WriteLine(b.CheckIfBoardIsFull());

        }
    }
}
