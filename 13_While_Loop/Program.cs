// About the while loop in c#
using System;
namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int even;
            int i = 2;
            Console.WriteLine("Enter the number upto which even number you want to print:");
            even = Convert.ToInt32(Console.ReadLine());
            while (i <= even)
            {
                Console.WriteLine(i);
                i += 2;
            }
            // This one is do whle loop
            int a;
            int j = 0;
            Console.WriteLine("Enter the number upto which you want to print:");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <= a);
        }
    }
}