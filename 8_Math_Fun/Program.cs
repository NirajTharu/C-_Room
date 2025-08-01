// About the inbuilt math functions in the C# 
// The various inbuilt math fucntions are:
// Math.max()-> Used to find the max of two given numbers
// Math.min()-> Used to find the min of two given numbers
// Math.Sqrt()-> Used to find the square root of the given number
// Math.Abs()-> Returns the absolute(positive) value of the input
// Math.Round()-> Returns a number to the nearest whole number

using System;

namespace MathFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11, b = 45;
            Console.WriteLine("The max value amoung 11 and 45 is: " + Math.Max(a, b));
            Console.WriteLine("The min value amoung 11 and 45 is:" + Math.Min(a, b));
            Console.WriteLine("The square root of 11 is:" + Math.Sqrt(64));
            Console.WriteLine("The square root of 45 is:" + Math.Sqrt(81));
            Console.WriteLine("The absoulte value of -99.3874 is", +Math.Abs(-99.3874));
            Console.WriteLine("The rounds a number  to the nearest whole number is 1000.99" + Math.Round(1000.99));
        }
    }
}
