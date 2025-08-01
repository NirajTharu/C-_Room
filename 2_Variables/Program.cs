// About the variables in the C#
// Variables are the containers used to store values 



/*
-> Names can contain letters, digits and the underscore character (_)
-> Names must begin with a letter or underscore
-> Names should start with a lowercase letter, and cannot contain whitespace
-> Names are case-sensitive ("myVar" and "myvar" are different variables)
-> Reserved words (like C# keywords, such as int or double) cannot be used as names
*/

using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 2;
            int myRoll = 18;
            string myName = "Niraj Kumar Chuaudhary.";
            System.Console.WriteLine("My name is " + myName + " I'am years " + myAge + " years old. " + " My rollNo is " + myRoll);
            if (myAge >= 22)
            {
                Console.WriteLine("You can Vote!");
            }
            else
            {
                Console.WriteLine("Insufficient Age for voting!");
            }
        }
    }
}