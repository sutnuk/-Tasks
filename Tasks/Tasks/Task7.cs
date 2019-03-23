using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Task7
    {
        private int number;

        public int Number { get => number; set => number = value; }

        public Task7(int number)
        {
            this.number = number;
        }

        public Task7() { }

        public bool isOdd()
        {
            return this.number % 2 == 0;
        }
        public List <Task7> Numbers(int[] arr)
        {
            List<Task7> result = new List<Task7> { };
            foreach (var i in arr)
                result.Add(new Task7(i));
            return result;

        }
    }
}
