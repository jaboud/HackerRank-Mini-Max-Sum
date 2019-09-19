using System;

namespace HackerRank_Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {


        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
            miniMaxSum(arr);
        }
    }
}
