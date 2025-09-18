// About the access modifier
// Modifiers in C#:
// public : can be access form all the classes
// private : can be access within the same class
// protected : code can be acces from the same class or inherited class
// internal : code is accessible form its own assembly
using System;
namespace Access_Modifier
{
    class Modifier
    {
        public string Name = "Niraj Kumar chaudhary";
        private int Marks_Obtain = 58;
        // protected string ip = "169.254.169.254";
        // internal string Device_used = "Tablet";

        public void display_M()
        {
            Console.WriteLine("The marks obtain is:" + Marks_Obtain);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Modifier m = new Modifier();
            Console.WriteLine(m.Name);
            m.display_M();
        }
    }
}