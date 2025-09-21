// About the exception handling in C#
// Try and catch;
using System;
namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The Try and catch is finished.");
            }
        }
    }
}
