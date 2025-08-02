// About the bool data type which have only two values True/False, On/Off, 1/0

using System;
namespace Bool_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 11;
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);

            if (a > b)
            {
                Console.WriteLine("The value of a and b is: " + $"{a} and {b}");
            }
            else
            {
                Console.WriteLine("a is not greater than b");
            }
        }
    }
}