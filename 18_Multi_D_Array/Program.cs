// About the multidimensional array 
// [,]-> Two dimensional array 
// Three dimensional array -> [ , , ]
using System;
namespace MultiDimensioanl
{
    class Program
    {
        static void Main(string[] args)
        {           int[,] numbers = { { 10, 101, 111 }, { 12, 13, 14 } };
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
