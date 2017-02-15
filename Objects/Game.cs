using System;
using System.Collections.Generic;

namespace GameApp.Objects
{
    public class Game
    {
        private string _playerOneInput;
        private string _playerTwoInput;

        public string Play(string playerOneInput, string playerTwoInput)
        {
            _playerOneInput = playerOneInput;
            _playerTwoInput = playerTwoInput;

            string p1wins = "Player 1 wins!";
            string p2wins = "Player 2 wins!";
            string draw = "It's a draw :(";

            if(_playerOneInput == "rock" && _playerTwoInput == "scissors" || _playerOneInput == "paper" && _playerTwoInput == "rock" || _playerOneInput == "scissors" && _playerTwoInput == "paper"  )
            {
                return p1wins;
            }
            else if (_playerOneInput == "scissors" && _playerTwoInput == "rock" ||_playerOneInput == "rock" && _playerTwoInput == "paper" || _playerOneInput == "paper" && _playerTwoInput == "scissors" )
            {
                return p2wins;
            }
            else if (_playerOneInput == _playerTwoInput)
            {
                return draw;
            }
            else
            {
                return null;
            }
        }

    }
}
