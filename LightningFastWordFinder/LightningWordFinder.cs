using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            //Solution 3
            string[] words = Regex.Split(text, "[^a-zA-Z]+");
            string longestString = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    longestString = s;
                    ctr = s.Length;
                }
            }

            return longestString;
            
        }
    }
}
