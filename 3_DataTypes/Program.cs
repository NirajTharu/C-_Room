// Data types in the C#
using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            long bank_balance = 9034323489898;
            float marks_obtain = 5.00F;
            double Pi = 3.14159265358979;
            char blood_G = 'O';
            string myName = "Dr. Death";
            bool Student = false;
            if (Student == true)
            {
                Console.WriteLine("Name is " + myName + ", Age is " + age + ",Marks Obtain is " + marks_obtain + ", Bank balance is " + bank_balance + " and blood group is " + blood_G + "+.");
            }
            else
            {
                Console.WriteLine("You are not student!");
                Console.WriteLine("The value of pi upto 14 decimal point is" + Pi);
            }
        }
    }
}