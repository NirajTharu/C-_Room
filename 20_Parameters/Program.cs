// When a parameter is passed to the method, is is called argument. So, Y_name and Y_age are parameters. Where as '22' and 'Niraj'  are the arguments.


using System;

namespace parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            age("22");
            name("Niraj");
            age();
            name();
            Console.WriteLine("The addition of number is " + add(22));
            key_pair(fruit: "Apple", x: 22, sewa: "e_Sewa");
        }
        // There is use of "Not Inserted" which is a default parameter.
        static void age(string Y_age = "Not Inserted")
        {
            Console.WriteLine("Age is " + Y_age);
        }
        static void name(string Y_name = "Not Inserted")
        {
            Console.WriteLine("Name is " + Y_name);
        }
        // Return value 
        static int add(int a)
        {
            return a + 33;
        }

        // Data in the form of key:value pair
        static void key_pair(string fruit, int x, string sewa)
        {
            Console.WriteLine("The name of the fruit is " + fruit);
            Console.WriteLine("The value of x is " + x);
            Console.WriteLine("The name of the sewa is " + sewa);
        }
    }
}