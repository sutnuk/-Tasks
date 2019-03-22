using System;

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

            /* int[] arr = { 5, 6, 12, 4, 88, 2, 44, 23 };
             Task2<int> task2 = new Task2<int> { };
             Console.WriteLine(task2.findMin(arr));
             Console.WriteLine(task2.findMax(arr));*/

            /*double[] arr1 = { 5.0, 6.0, 12.0, 4.0, 88.0, 2.1, 4.4, 23.0 };
            Task2<double> task2_1 = new Task2<double> { };
            Console.WriteLine(task2_1.findMin(arr1));
            Console.WriteLine(task2_1.findMax(arr1));*/

            //////////////   TASK 3    /////////////////

            int[] arr = { 5, 6, 12, 4, 88, 2, 44, 23 };
            Task3<int> task3 = new Task3<int> { };
            task3.filterArray(arr, 2, 12);

            double[] arr1 = { 5.4, 6.2, 12.0, 5.4, 8.8, 0.2, 4.4, 2.3 };
            Task3<double> task3_1 = new Task3<double> { };
            task3_1.filterArray(arr1, 0.0, 5.0);



            Console.ReadKey();

        }
    }
}
