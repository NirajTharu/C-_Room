// Switch statemtn in the Enum(Enumerators)
using System;
namespace Switch_Statement
{
    class Program
    {
        enum Months
        {
            January,
            Febrary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Months m = Months.April;
            // To Check the default case
            // Months m = (Months)20;
            switch (m)
            {
                case Months.January:
                    Console.WriteLine("This is January.");
                    break;
                case Months.Febrary:
                    Console.WriteLine("This is Febrary.");
                    break;
                case Months.March:
                    Console.WriteLine("This is March.");
                    break;
                case Months.April:
                    Console.WriteLine("This is April.");
                    break;
                case Months.May:
                    Console.WriteLine("This is May.");
                    break;
                case Months.June:
                    Console.WriteLine("This is June.");
                    break;
                case Months.July:
                    Console.WriteLine("This is July.");
                    break;
                case Months.August:
                    Console.WriteLine("This is August.");
                    break;
                case Months.September:
                    Console.WriteLine("This is September.");
                    break;
                case Months.October:
                    Console.WriteLine("This is October.");
                    break;
                case Months.November:
                    Console.WriteLine("This is November.");
                    break;
                case Months.December:
                    Console.WriteLine("This is December.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}