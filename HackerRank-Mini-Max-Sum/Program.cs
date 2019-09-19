using System;

namespace HackerRank_Mini_Max_Sum
{
    class Program
    {
        static void MiniMaxSum(int[] arr)
        {
            //Reference the Array class to sort arrays from least greatest
            Array.Sort(arr);
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
            MiniMaxSum(arr);
        }
    }
}
