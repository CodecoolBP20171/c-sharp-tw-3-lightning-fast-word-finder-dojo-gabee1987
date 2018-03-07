using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            #region Solution 1

            // Solution 1
            //string cleanText = Regex.Replace(text, "[^a-zA-Z]+", " ", RegexOptions.Compiled); // With using RegexOptions.Compiled its faster aproxx 13sec
            //string[] words = cleanText.Split(' ');
            //List<int> listOfWords = words.Select(word => word.Length).ToList();
            //int maxIndex = listOfWords.IndexOf(listOfWords.Max());
            //return words[maxIndex];

            // Avarage runtime: 67,2958923

            #endregion


            #region Solution 2

            //// Solution 2
            //string cleanText = Regex.Replace(text, "[^a-zA-Z]+", " ", RegexOptions.Compiled); // With using RegexOptions.Compiled its faster aproxx 13sec
            ////string[] words = Regex.Split(text, "[^a-zA-Z]+");  // Combined Regex.Split is slower that Regex.Replace than Split
            //string[] words = cleanText.Split(' ');
            //string longestString = "";
            //int ctr = 0;
            //foreach (String s in words)
            //{
            //    if (s.Length > ctr)
            //    {
            //        longestString = s;
            //        ctr = s.Length;
            //    }
            //}
            //return longestString;

            // Avarage runtime: 63,5986973

            #endregion

            #region Solution 3

            // Solution 3
            string longestString = "";
            int charCounter = 0;
            int maxValue = 0;
            int indexCounter = 0;
            int indexOfLongest = 0;
            foreach (char ch in text)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                {
                    charCounter += 1;
                }
                else
                {
                    if (charCounter >= maxValue)
                    {
                        maxValue = charCounter;
                        indexOfLongest = indexCounter - maxValue;
                    }
                    charCounter = 0;
                }
                indexCounter += 1;
            }
            longestString = text.Substring(indexOfLongest, maxValue);
            return longestString;

            // Avarage runtime: 7,1186066

            #endregion
        }
    }
}
