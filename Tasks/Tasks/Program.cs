using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////   TASK 1    /////////////////

            /*Task1 task1 = new Task1();
            Console.WriteLine(task1.chooseBigger(8, 6));*/

            //////////////   TASK 2    /////////////////

            /*int[] arr = { 5, 6, 12, 4, 88, 2, 44, 23 };
             Task2<int> task2 = new Task2<int> { };
             Console.WriteLine(task2.findMin(arr));
             Console.WriteLine(task2.findMax(arr));*/

            /*double[] arr1 = { 5.0, 6.0, 12.0, 4.0, 88.0, 2.1, 4.4, 23.0 };
            Task2<double> task2_1 = new Task2<double> { };
            Console.WriteLine(task2_1.findMin(arr1));
            Console.WriteLine(task2_1.findMax(arr1));*/

            //////////////   TASK 3    /////////////////

            /*int[] arr = { 5, 6, 12, 4, 88, 2, 44, 23 };
            Task3<int> task3 = new Task3<int> { };
            task3.filterArray(arr, 2, 12);*/

            /*double[] arr1 = { 5.4, 6.2, 12.0, 5.4, 8.8, 0.2, 4.4, 2.3 };
            Task3<double> task3_1 = new Task3<double> { };            
            ICollection <double> list = task3_1.filterArray(arr1, 0.0, 5.0);
            foreach (double i in list)
                Console.WriteLine(i);*/

            //////////////   TASK 4    /////////////////

            /*string text = "Some   rrr text ++" ;
            Task4 task4 = new Task4();
            Console.WriteLine(task4.wordsCounter(text));*/

            //////////////   TASK 5    /////////////////

            /*Task5 task5 = new Task5();
            double x = 4, y = 10;
            double Multiply = task5.mult(x, 5);
            double Divide = task5.div(y, 2);
            double Sum = task5.sum(x, Multiply);
            double Substact = task5.sub(Sum, Divide);
            Console.WriteLine(Substact);*/

            //////////////   TASK 6    /////////////////

            /*Task6 task6 = new Task6();
            string text = "Implement that gggg function takes two two parameters ";
            string[] words = { "that", "two" };
            var res = task6.repeatCount(text, words);
            foreach (var res1 in res)
            {
                Console.WriteLine(res1.Word + " " + res1.Count);
            }*/

            //////////////   TASK 7    /////////////////

            Task7 task7 = new Task7();
            int[] arr = { 5, 6, 12, 4, 88, 2, 44, 23 };
            var res = task7.Numbers(arr);
            foreach (var res1 in res)
            {
                Console.WriteLine(res1.isOdd());
            }
            


           Console.ReadKey();

        }
    }
}
