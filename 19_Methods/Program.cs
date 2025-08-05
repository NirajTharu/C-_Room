// About the methods in the c# 
// Method aslo know as  function takes input or inputs(arguments)
using System;
namespace methods
{
    class Program
    {
        static void Your_name()
        {
            string name;
            Console.WriteLine("Enter Your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}");
        }
        static void Main(string[] args)
        {
            Your_name();
        }
    }
}