using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tasks
{
    class Task4
    {
        public int wordsCounter(string text)
        {
            int count = 0;
            text = Regex.Replace(text, @"\s+", " ");
            string[] words = text.Split(" ");
            foreach (string i in words)                
                count++;
            return count;
        }
    }
}
