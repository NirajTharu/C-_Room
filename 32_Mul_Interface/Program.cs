// About the multiple interface in the C#
// To implement multiple interfaces, separate them with a comma.

using System;
namespace Mul_Interface
{
    interface First_Class
    {
        void About_FC();
    }
    interface Second_Class
    {
        void About_SC();
    }
    class Main_Class : First_Class, Second_Class
    {
        public void About_FC()
        {
            Console.WriteLine("This Data is of the first Class.");
        }
        public void About_SC()
        {
            Console.WriteLine("This Data is from the Second Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Main_Class m = new Main_Class();
            m.About_FC();
            m.About_SC();
        }
    }
}

