
// About the user input in the C#

using System;
namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            int age;
            Console.WriteLine("Enter the User name:");
            username = Console.ReadLine()!; //If you don't add ! then it will output an error and '!' sign tells the complier don't worry the value in the variable will not be null
            Console.WriteLine("Enter the age of the user:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The User name is " + username + " And the age is " + age);
        }
    }
}