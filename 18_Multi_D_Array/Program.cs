// About the multidimensional array 
using System;
namespace MultiDimensioanl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 10, 101, 111, 132 }, { 12, 13, 14, 15 } };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Using the for loop:");
            // Accessing the array elements using for loop
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }
    }
}
