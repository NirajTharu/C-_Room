// About the for loop in C#
using System;
namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested for loop
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}