using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeGame;

namespace TicTacToe.Tests
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void CheckIfCellIsMarkedX()
        {
            Cell cell = new Cell();
            Mark expectedMark = Mark.X;
            cell.SetMark(Mark.X);
            Mark actualMark = cell.GetMark();
            Assert.AreEqual(expectedMark, actualMark);            
        }

        public void CheckIfCellIsMarkedO()
        {
            Cell cell = new Cell();
            Mark expectedMark = Mark.O;
            cell.SetMark(Mark.O);
            Mark actualMark = cell.GetMark();
            Assert.AreEqual(expectedMark, actualMark);
        }

        public void CheckIfCellThrowsCellAlreadyMarkedException()
        {
            Cell cell = new Cell();
            string msg = null;
            cell.SetMark(Mark.X);
            try
            {
                cell.SetMark(Mark.O);
            }
            catch(Exception e)
            {
                msg = e.Message;
            }
            Assert.AreEqual(msg, "Cell is already marked");
        }
    }
}
