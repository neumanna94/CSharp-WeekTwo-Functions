using System.Collections.Generic;
using System;
namespace PalinAndFR.Models
{
    public class RockPaperScissors
    {
        private string _playerOneMove;
        private string _playerTwoMove;
        private string _winner;

        public RockPaperScissors(string playerOne, string playerTwo)
        {
            _playerOneMove = playerOne.ToLower();
            _playerTwoMove = playerTwo.ToLower();
        }
        public void SetPlayerTwo(string moveIn)
        {
            _playerTwoMove = moveIn;
        }
        public void AIPlay()
        {
            RandomGeneratePlayerTwo();
            CheckWinner();
        }
        public void RandomGeneratePlayerTwo()
        {
            Random r = new Random();
            int roll = r.Next(0, 3);
            Console.WriteLine(roll);
            if(roll == 0)
            {
                SetPlayerTwo("r");
            } else if(roll == 1)
            {
                SetPlayerTwo("p");
            } else {
                SetPlayerTwo("s");
            }
        }
        public string CheckWinner()
        {
            if(_playerOneMove == "r")
            {
                if(_playerTwoMove == "p")
                {
                    _winner = "Player 2 Paper Wins!";
                } else if(_playerTwoMove == "r")
                {
                    _winner = "Draw!";
                } else
                {
                    _winner = "Player 1 Rock Wins!";
                }
            }
            if(_playerOneMove == "p")
            {
                if(_playerTwoMove == "s")
                {
                    _winner = "Player 2 Scissors Wins!";
                } else if(_playerTwoMove == "p")
                {
                    _winner = "Draw!";
                } else
                {
                    _winner = "Player 1 Paper Wins!";
                }
            }
            if(_playerOneMove == "s")
            {
                if(_playerTwoMove == "r")
                {
                    _winner = "Player 2 Rock Wins!";
                } else if(_playerTwoMove == "s")
                {
                    _winner = "Draw!";
                } else
                {
                    _winner = "Player 1 Paper Wins!";
                }
            }
            return _winner;
        }
    }
}
