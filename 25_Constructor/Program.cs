// Constructor is a special type of the Method that is used to initialze the objects.

using System;
namespace Constructor
{
    class Living_Being
    {
        public string name;
        public string made;
        public string belongs;
        public Living_Being(string creature_name, string made_of, string belongs_to)
        {
            name = creature_name;
            made = made_of;
            belongs = belongs_to;
        }
        static void Main(string[] args)
        {
            Living_Being l = new Living_Being("Human", "cells", "Mammalia");

            Console.WriteLine(l.name + "is  made of " + l.made + " and belongs to " + l.belongs);
        }
    }
}