using System.Collections.Generic;
using System;
using System.Linq;
namespace PalinAndFR.Models
{
    public class Anagram
    {
        private string _currString;
        List<string> _listOfAnagrams = new List<string>{};
        public Anagram(string inputString)
        {
            _currString = inputString;
            GenerateListOfAnagrams();
        }
        public string HtmlResult()
        {
          return returnListAsString();
        }
        public void GenerateListOfAnagrams()
        {
            char[] newString = _currString.ToCharArray();
            string useThisCurrentString = _currString;
            for(int j = 0; j < newString.Length; j ++)
            {
                useThisCurrentString = _currString;
                for(int i = 0; i < newString.Length; i ++)
                {
                    char saveThisChar = newString[i];
                    newString[i] = newString[j];
                    newString[j] = saveThisChar;
                    _listOfAnagrams.Add(CharArrayToString(newString));
                    newString = useThisCurrentString.ToCharArray();

                }
            }
        }
        public string CharArrayToString(char[] inputArray)
        {
            string outputString = "";
            for(int i = 0; i < inputArray.Length; i ++)
            {
                outputString += inputArray[i];
            }
            return outputString;
        }

        public string returnListAsString()
        {
            removeDuplicates();
            string outputString = "";
            for(int i = 0; i < _listOfAnagrams.Count; i ++)
            {
                outputString += _listOfAnagrams[i] + ", ";
            }
            return outputString;
        }

        public void removeDuplicates()
        {
            List<string> outputList = new List<string>{};
            outputList = _listOfAnagrams.Distinct().ToList<string>();
            _listOfAnagrams = outputList;
        }
    }
}
