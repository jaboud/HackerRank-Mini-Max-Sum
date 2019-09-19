using System;
using System.Linq;

namespace HackerRank_Mini_Max_Sum
{
    class Program
    {
        static void MiniMaxSum(int[] arr)
        {
            //Array class is referenced to sort arrays from least to greatest
            Array.Sort(arr);

            //The variables 'min' and 'max' are declared as a long type due to hackerrank question statting it could be greater than a 32bit integer.

            //Take function is referenced from the System.linq and it outputs the number of elements in the array which is specified in the parameters
            //then the elements are added with the sum function.
            long min = arr.Take(4).Sum();
            //Skip function is referenced from the System.linq and it skips the specified element referenced within the parameters'
            //then the elements are added with the sum function.
            long max = arr.Skip(1).Sum();

            Console.WriteLine($"{min} {max}");
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
            MiniMaxSum(arr);

            Console.Read();
        }
    }
}
