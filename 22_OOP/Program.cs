// The OOP(Object Oriented Programming) concept
// The template for the object is class
// The instance of class is object
using System;
namespace OOP
{
    class Car
    {
        string name = "V 60";
        string brand = "volvo";

        static void Main(string[] args)
        {
            Car c1 = new Car(); //Created c1 Object of the class Car.
            Console.WriteLine("The Name of the car is: " + c1.name);
            Console.WriteLine("The brand of the car is: " + c1.brand);
        }
    }
}