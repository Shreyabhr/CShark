using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeGame;

namespace TicTacToe.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void CheckIfResultIsWinOnRowWin()
        {
            Result expectedResult = Result.WIN;
            Player p1 = new Player("abc", Mark.X);
            Player p2 = new Player("def", Mark.O);
            List<Player> player = new List<Player>();
            player.Add(p1);
            player.Add(p2);

            Board b = new Board(3);
          
            ResultAnalyzer result = new ResultAnalyzer(b);
            Game game = new Game(player,b,result);

            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            Result actualResult = game.Play(2);

            Assert.AreEqual(expectedResult, actualResult);
          
        }

        [TestMethod]
        public void CheckIfCurrentPlayerIsTheFirstPlayerAddedInList()
        {
            Player p1 = new Player("abc", Mark.X);
            Player p2 = new Player("def", Mark.O);
            List<Player> player = new List<Player>();
            player.Add(p1);
            player.Add(p2);

            Player expectedPlayer = p1;

            Board b = new Board(3);
            ResultAnalyzer result = new ResultAnalyzer(b);

            Game game = new Game(player, b, result);

            Player actualPlayer = game.GetCurrentPlayer();

            Assert.AreEqual(expectedPlayer, actualPlayer);
        }
    }
}
