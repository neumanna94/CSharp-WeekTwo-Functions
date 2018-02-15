// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// J, X                               8
// Q, Z                               10
using System.Collections.Generic;
using System;
namespace PalinAndFR.Models
{
    public class Scrabble
    {
        private string _myCurrentString;

        public Scrabble(string inputString)
        {
            _myCurrentString = inputString;
        }
        public string GetString()
        {
            return _myCurrentString;
        }
        public void SetString(string inputString)
        {
            _myCurrentString = inputString;
        }
        public string HtmlResult()
        {
          return ScrabbleScore().ToString();
        }
        public int ScrabbleScore()
        {
            int sum = 0;
            string myInputString = _myCurrentString;
            for(int i = 0; i < myInputString.Length; i ++)
            {
                sum += LetterScore(myInputString[i]);
            }
            return sum;
        }

        public int LetterScore(char inputString)
        {
            int scoreOut = 0;
            if(inputString == 'A' || inputString =='E' || inputString =='I' || inputString =='O' || inputString =='U' || inputString =='L' || inputString =='N' || inputString =='R' || inputString =='S' || inputString =='T'){
                return 1;
            } else if(inputString =='D' || inputString =='G')
            {
                return 2;
            } else if(inputString =='B' || inputString == 'C' || inputString == 'M' || inputString =='P')
            {
                return 3;
            } else if(inputString =='F' || inputString =='H' || inputString =='V' || inputString =='W' || inputString =='Y')
            {
                return 4;
            } else if(inputString =='K')
            {
                return 5;
            } else if(inputString =='J' || inputString == 'X')
            {
                return 8;
            } else if(inputString =='Q' || inputString =='Z'){
                return 10;
            } else {
                return 0;
            }
        }



    }
}
