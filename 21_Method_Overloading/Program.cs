// Performing the same operation in the different data type



using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int added_Number = add(99, 101);
            double added_Number1 = add(33.2343, 343243.3423);
            Console.WriteLine("The addition of two integer is: " + added_Number);
            Console.WriteLine("The addition of two double numbers is: " + added_Number1);

        }
        static int add(int x, int y)
        {
            return x + y;
        }

        static double add(double i, double j)
        {
            return i + j;
        }
    }
}
