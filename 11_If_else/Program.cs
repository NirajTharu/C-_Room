// About (Conditional) the if else

using System;
namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can Vote!");
            }
            else
            {
                Console.WriteLine("You can't vote");
            }
        }
    }
}
