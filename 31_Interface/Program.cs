// Interface -> is Completely the 'abstact class' which can only contain abstract method and abstract properties(with empty bodies)

// It is considered good practice to start with the letter "I" at the beginning of an interface.
// By default, members of an interface are abstract and public.

using System;
namespace Interface
{
    class Program
    {
        interface NID
        {
            void Address();
            void Networth();
        }
        class Person_Details : NID
        {
            public void Address()
            {
                Console.WriteLine("Is from...");
            }
            public void Networth()
            {
                Console.WriteLine("Networth is...");
            }
        }
        static void Main(string[] args)
        {
            Person_Details p = new Person_Details();
            p.Address();
            p.Networth();
        }
    }
}