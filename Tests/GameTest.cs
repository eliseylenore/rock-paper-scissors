using Xunit;
using GameApp.Objects;
using System;
using System.Collections.Generic;

namespace GameApp
{
    public class GameTest
    {
        // this will test rock vs scissors for player one
        [Fact]
        public void Play_RockVScissors_Player1Wins()
        {
            //arrange
            string winnerResult = "Player 1 wins!";
            Game newGame = new Game();

            //act
            string result = newGame.Play("rock", "scissors");

            //assert
            Assert.Equal(winnerResult, result);
        }

        // this will test rock vs Paper for player two
        [Fact]
        public void Play_RockVPaper_Player2Wins()
        {
            //arrange
            string winnerResult = "Player 2 wins!";
            Game newGame = new Game();

            //act
            string result = newGame.Play("rock", "paper");

            //assert
            Assert.Equal(winnerResult, result);
        }

        // this will test paper vs scissors for player one
        [Fact]
        public void Play_PaperVScissors_Player1Wins()
        {
            //arrange
            string winnerResult = "Player 1 wins!";
            Game newGame = new Game();

            //act
            string result = newGame.Play("scissors", "paper");

            //assert
            Assert.Equal(winnerResult, result);
        }

        // this will test paper vs scissors for player two
        [Fact]
        public void Play_PaperVScissors_Player2Wins()
        {
            //arrange
            string winnerResult = "Player 2 wins!";
            Game newGame = new Game();

            //act
            string result = newGame.Play("paper", "scissors");

            //assert
            Assert.Equal(winnerResult, result);
        }

        [Fact]
        public void Play_PaperVPaper_Draw()
        {
            //arrange
            string winnerResult = "It's a draw :(";
            Game newGame = new Game();

            //act
            string result = newGame.Play("paper", "paper");

            //assert
            Assert.Equal(winnerResult, result);
        }
    }
}
