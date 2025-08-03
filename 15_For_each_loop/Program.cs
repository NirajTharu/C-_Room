// About the for each loop 
using System;
namespace ForEach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = ["Jeep", "BYD", "Tata", "Volvo"];
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }

    }
}