// About the get and set properties in C#
using System;
namespace properties
{
    class Used_Properties
    {
        public string Name
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Used_Properties u = new Used_Properties();
            u.Name = "Niraj Kumar Chaudhary";
            Console.WriteLine(u.Name);
        }
    }
}