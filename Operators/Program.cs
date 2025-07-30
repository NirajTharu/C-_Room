// About the various operators used in the C#
using System;
namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmethic operators: +, -, *, /, %, ++, --
            int a = 10, b = 5;
            Console.WriteLine("The addition is " + (a + b));
            Console.WriteLine("The Subtraction is " + (a - b));
            Console.WriteLine("The Multiplication is " + (a * b));
            Console.WriteLine("The Division is " + (a / b));
            Console.WriteLine("The Modulo is " + (b % a));
            Console.WriteLine("The Increment is " + (a++));
            Console.WriteLine("The Decrement is " + (b--));


            // Assignment operators: =, +=, -=, *=, /=, %=, &= |=, ^=, >>=, <<=
            int c = 7; //Assignment operator
            Console.WriteLine("The use of asignment operators:");
            Console.WriteLine(c += 7);
            Console.WriteLine(c -= 7);
            Console.WriteLine(c *= 7);
            Console.WriteLine(c /= 7);
            Console.WriteLine(c %= 7);
            Console.WriteLine(c &= 7);
            Console.WriteLine(c |= 7);
            Console.WriteLine(c ^= 7);
            Console.WriteLine(c >>= 7);
            Console.WriteLine(c <<= 7);

            // Comparision operators: ==,!=,<=,>=,>,<
            // Returns Ture or False

            int d = 5;
            int e = 9;
            Console.WriteLine(d == e);
            Console.WriteLine(d != e);
            Console.WriteLine(d < e);
            Console.WriteLine(d > e);
            Console.WriteLine(d <= e);
            Console.WriteLine(d >= e);

            // Logical operators:&&,||,!
            // Returns True or False
            int f = 99, g = 88;
            Console.WriteLine(f > g && g < f);
            Console.WriteLine(f >= g || g >= f);
            Console.WriteLine(!(f > g));
        }
    }
}