// About the multiple objects and classes
using System;
namespace Mul_obj_class
{
    class Car
    {
        public string name = "Spider";
        public string brand = "Ferrari";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Console.WriteLine($"The name of the car  brand is: {c1.brand} and car name is: {c1.name}");
        }
    }
}