using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeGame;

namespace TicTacToe.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void CheckIfPlayerMarkIsX()
        {
            Mark expectedMark = Mark.X;
            Player player = new Player("abc",Mark.X);
            Mark actualMark = player.GetMark();
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void CheckIfPlayerMarkIsO()
        {
            Mark expectedMark = Mark.O;
            Player player = new Player("abc", Mark.O);
            Mark actualMark = player.GetMark();
            Assert.AreEqual(expectedMark, actualMark);
        }
    }
}
