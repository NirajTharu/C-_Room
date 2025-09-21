// Enum is the special class that represents a grou of constants(unchangeable/read-only variables).

// Enum is hort for "enumerators", which means "Specifically listed".

using System;
namespace Enum
{
    enum List
    {
        spoon,
        plate,
        cooker,
        bucket = 7,
        glass
    }
    class Program
    {
        static void Main(string[] args)
        {
            List l = List.plate;
            Console.WriteLine(l);

            // By default, the first item of an enum has the value 0. The second has the value 1, and so on.

            // To get the integer value from an item, you must explicitly convert the item to an int:

            int L = (int)List.plate;
            Console.WriteLine(L);

            // You can also assign your own enum values, and the next items will update their numbers accordingly:
            int p = (int)List.bucket;
            Console.WriteLine(p);
        }
    }
}