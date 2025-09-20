// About the inheritance 

// The process of inheriting field and methods from one class to another.

// Inheritance is catogorized in two:
// 1. Derived class (Child) -> The class to which the data is derived too.  
// 2. Base class (Parent) -> The class form which the data is derived.

using System;

namespace Not_In_Land
{
    class Aircraft
    {
        public string Brand_Name = "Air Bus";
        public void Can_fly()
        {
            Console.WriteLine("Can fly in the air.");
        }
    }

    class Air_Bus : Aircraft
    {
        public string Name = "The double-deck A380";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Air_Bus a = new Air_Bus();
            Console.WriteLine("The name of the Aircraft is: " + a.Name);
            a.Can_fly();
        }
    }
}
