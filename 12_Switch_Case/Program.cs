// About the switch Case
using System;
namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter any one from 1 to 7 to get the name of day:");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is sunday!");
                    break;
                case 2:
                    Console.WriteLine("Today is monday!");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday!");
                    break;
                case 4:
                    Console.WriteLine("Today is Wednesday!");
                    break;
                case 5:
                    Console.WriteLine("Today is Thrusday!");
                    break;
                case 6:
                    Console.WriteLine("Today is Fry day!");
                    break;
                case 7:
                    Console.WriteLine("Today is saturday!");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}