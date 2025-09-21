// About the file functions in C#
using System;
using System.IO;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string C_sharp = "This is the first file which is about the C#.";
            File.WriteAllText("FirstFile.txt", C_sharp);

            string view_C_sharp = File.ReadAllText("FirstFile.txt");
            Console.WriteLine(view_C_sharp);
        }
    }
}