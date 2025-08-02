
// About the string in the C#
// String is set of characters surrounded by double quotes

using System;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string app = "App store , Books";
            Console.WriteLine("The sting is " + app);
            // For the length of the input string
            Console.WriteLine("The Length of the string is: " + app.Length);
            Console.WriteLine("The given string is changed to lower:" + app.ToLower());
            Console.WriteLine("The given string is changed to lower:" + app.ToUpper());

            // For the string concatination
            string Fname = "Niraj ";
            string Mname = "Kumar ";
            string Lname = "Chaudhary";
            string FullName = Fname + Mname + Lname;
            Console.WriteLine("The Full name is " + FullName);
            // OR
            Console.WriteLine("Full Name is:" + string.Concat(Fname, Mname, Lname));

            // For sting interpolation
            string fname = "Nani";
            string lname = "Nani";
            Console.WriteLine("Full name is:" + $"{fname} {lname}");
            Console.WriteLine("First Character is:" + lname[0]);
            Console.WriteLine("Index of 'n'is: " + lname.IndexOf('n'));


            // The use of escape character for the special symbols 
            // This will result : \'-> ',\"-> ",\\->\ 
            string G_Name = "SadlessFace\'s is my game name.I\'m not too good in playing online games.";
            Console.WriteLine(G_Name);

        }
    }
}