// About the break and continue statements in C#
using System;
namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number upto which you want to print the even number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Printing the even numbers except the number 14.");
            for (int i = 2; i <= a; i += 2)
            {
                if (i == 14) //This will skip the 14 
                {
                    continue;
                }
                else if (i == 1000) //If the output reach to 1000 the program will end atomatically
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}