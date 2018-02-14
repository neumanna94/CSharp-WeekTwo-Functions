using System.Collections.Generic;
using System;
namespace PalinAndFR.Models
{
    public class Palindrome
    {
        private string _myCurrentString;
        private bool _isPalindrome;

        public Palindrome(string inputString)
        {
            _myCurrentString = inputString;
        }

        public void SetString(string inputString)
        {
            _myCurrentString = inputString;
        }
        public string GetString()
        {
            return _myCurrentString;
        }
        public bool CheckPalindrome()
        {
            //8 [0,1,2,3,4,5,6,7]
            int palindromeLength = _myCurrentString.Length;
            string lowerMyCurrentString = _myCurrentString.ToLower();
            int j = palindromeLength - 1;

            for(var i = 0; i < palindromeLength/2 ; i ++)
            {
                if(lowerMyCurrentString[i] != lowerMyCurrentString[j])
                {
                    _isPalindrome = false;
                    return false;
                } else {

                }
                j--;
            }
            _isPalindrome = true;
            return true;
        }
    }
}
