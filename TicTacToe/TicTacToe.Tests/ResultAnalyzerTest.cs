using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeGame;

namespace TicTacToe.Tests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void CheckIfRowWinOnInputXOnFirstRow()
        {
            bool expectedResult = true;
            Board b = new Board(3);
            b.MarkCell(0, Mark.X);
            b.MarkCell(1, Mark.X);
            b.MarkCell(2, Mark.X);

            ResultAnalyzer result = new ResultAnalyzer(b);
            bool actualResult = result.CheckRow();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckIfColumnWinOnInputXOnFirstColumn()
        {
            bool expectedResult = true;
            Board b = new Board(3);
            b.MarkCell(0, Mark.X);
            b.MarkCell(3, Mark.X);
            b.MarkCell(6, Mark.X);

            ResultAnalyzer result = new ResultAnalyzer(b);
            bool actualResult = result.CheckColumn();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckIfDiagonalWinOnInputOOnUpperDiagonal()
        {
            bool expectedResult = true;
            Board b = new Board(3);
            b.MarkCell(0, Mark.X);
            b.MarkCell(4, Mark.X);
            b.MarkCell(8, Mark.X);

            ResultAnalyzer result = new ResultAnalyzer(b);
            bool actualResult = result.CheckUpperDiagonal();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckIfDiagonalWinOnInputOOnLowerDiagonal()
        {
            bool expectedResult = true;
            Board b = new Board(3);

            b.MarkCell(2, Mark.X);
            b.MarkCell(4, Mark.X);
            b.MarkCell(6, Mark.X);

            ResultAnalyzer result = new ResultAnalyzer(b);
            bool actualResult = result.CheckLowerDiagonal();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckIfGameIsDraw()
        {
            bool expectedResult = true;
            Board board = new Board(3);
            board.MarkCell(0, Mark.X);
            board.MarkCell(1, Mark.X);
            board.MarkCell(2, Mark.O);
            board.MarkCell(3, Mark.O);
            board.MarkCell(4, Mark.O);
            board.MarkCell(5, Mark.X);
            board.MarkCell(6, Mark.X);
            board.MarkCell(7, Mark.O);
            board.MarkCell(8, Mark.X);

            ResultAnalyzer result = new ResultAnalyzer(board);
            bool actualResult = result.Draw();

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
