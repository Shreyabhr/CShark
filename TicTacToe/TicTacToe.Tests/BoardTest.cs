using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TicTacToeGame;

namespace TicTacToe.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CheckIfBoardSizeIs9OnInput3()
        {
            int expectedSize = 9;
            Board board = new Board(3);
            int actualSize = board.GetBoard().Count;
            Assert.AreEqual(expectedSize, actualSize);

        }
        [TestMethod]
        public void CheckIfBoardIsFullAfterFillingAllCells()
        {
            bool expectedResult = true;
            Board board = new Board(3);
            board.MarkCell(0, Mark.X);
            board.MarkCell(1, Mark.X);
            board.MarkCell(2, Mark.X);
            board.MarkCell(3, Mark.X);
            board.MarkCell(4, Mark.X);
            board.MarkCell(5, Mark.X);
            board.MarkCell(6, Mark.X);
            board.MarkCell(7, Mark.X);
            board.MarkCell(8, Mark.X);
            bool actualResult = board.CheckIfBoardIsFull();
            Console.WriteLine(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void CheckIfCellIsCorrectlyMarked()
        {
            Mark expectedMark = Mark.X;
            Board board = new Board(3);
            board.MarkCell(4, Mark.X);
            Mark actuaMark = board.GetBoard().ElementAt(4).GetMark();
            Assert.AreEqual(expectedMark, actuaMark);
        }
    }
}
