using System;

namespace The_array_s_largest_number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 18, 13, 6, 66, 35 };
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    Console.Write("The largest pieces: " + arr[i]);
                }
            }
        }
    }
}
