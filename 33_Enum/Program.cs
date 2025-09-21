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
        bucket,
        glass
    }
    class Program
    {
        static void Main(string[] args)
        {
            List l = List.plate;
            Console.WriteLine(l);
        }
    }
}