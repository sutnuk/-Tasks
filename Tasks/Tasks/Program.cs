using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Console.WriteLine(task1.chooseBigger(8, 6));
            Console.ReadKey();

        }
    }
}
