// Type castign is the process of converting a variable or an object of one data type to another.
// There are two types of type casting: a. Inplicit and another is explicit
// Implicit(automatically) type casting is done by the compiler. Example of implicit type conversion is: Char->Int->long->float->double
// Where as the Explicit type conversion is done by help of inbuilt functions like Convert.Toboolen(),Convert.ToString(),Convert.ToInt32(),etc.
// Example of explicit type conversion:Double->float->long->Int->Char
// Some of the explicit type conversion methods are:Convert.ToBoolen,Convert.ToDouble,Convert.ToString,Convet.ToInt32(Int),Convert.ToInt64(long)
using System;
namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            char _1Alpha = 'A';
            int chosen_Num = 55;
            double Avg_height_of_boy_in_nepal_cm = 162.31;

            int alpha = _1Alpha;
            float Num = chosen_Num;
            int avg_height_cm = Convert.ToInt32(Avg_height_of_boy_in_nepal_cm);

            Console.WriteLine("(Implicit) The intiger value of char 'A' is: " + alpha);
            Console.WriteLine("Implicit , The avarage height in int form is: " + Num);
            Console.WriteLine("The Explicit type conversion of int: " + avg_height_cm);
        }
    }
}