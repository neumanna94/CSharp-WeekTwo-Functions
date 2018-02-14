using System.Collections.Generic;
using System;
namespace PalinAndFR.Models
{
    public class FindAndReplace
    {
        private string _total;
        private string _find;
        private string _replace;

        public FindAndReplace(string total, string find, string replace)
        {
            _total = total;
            _find = find;
            _replace = replace;
        }
        public string FindReplace()
        {
            List<string> splitList = splitter(" ");

            string outputString = "";
            for(int i = 0; i < splitList.Count; i ++)
            {
                if(splitList[i] == _find)
                {
                    splitList[i] = _replace;
                } else {

                }
            }
            for(int i = 0; i < splitList.Count; i ++)
            {
            }
            for(int i = 0; i < splitList.Count; i ++)
            {
                outputString += splitList[i].ToString() + " ";
            }

            return outputString;
        }
        public List<string> splitter(string splitBy)
        {
            List<string> outputList = new List<string>{};
            int j = 0;
            for(int i = 0; i < _total.Length; i ++)
            {
                if(_total[i].ToString() == " " && j == 0)
                {
                    outputList.Add(_total.Substring(j,i-j));
                    j=i;
                } else if(_total[i].ToString() == " " && j > 0)
                {
                    outputList.Add(_total.Substring(j+1,i-j-1));
                    j=i;
                }
            }
            outputList.Add(_total.Substring(j+1, _total.Length-j-1));
            return outputList;
        }

    }
}
