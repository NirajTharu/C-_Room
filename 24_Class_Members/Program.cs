// About the class members and member functions
// The variables inside the class are fields.

using System;
namespace Members
{
    class P_Name
    {
        string Program_Name = "C";
        string Main_Use = "Building Operating System";

        public void display()
        {
            Console.WriteLine($"The Name of the program is: {Program_Name} and Main use case is: {Main_Use}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            P_Name p = new P_Name();
            p.display();
        }
    }
}