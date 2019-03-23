using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Task6
    {
        private string word;
        private int count;

        public Task6() { }

        public Task6(string word, int count)
        {
            this.Word = word;
            this.Count = count;
        }

        public string Word { get => word; set => word = value; }
        public int Count { get => count; set => count = value; }

        public List<Task6> repeatCount(string text, string[] words)
        {
            List<Task6> result = new List<Task6> { };
            for (int i = 0; i < words.Length; i++)
            {
                string str = text.ToLower();
                int index = str.IndexOf(words[i]);
                int count = 0;
                while (index != -1)
                {
                    count++;
                    index = str.IndexOf(words[i], index+1);
                }
                result.Add(new Task6(words[i], count));
            }
            return result;

        }
    }
}

	