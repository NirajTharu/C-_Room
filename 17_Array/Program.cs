// About the array in the C#
using System;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'];
            foreach (char i in alphabet)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(alphabet[0]); //For accessing the array element
            Console.WriteLine(alphabet.Length); //For Knowing the length of the array

            string[] colors = ["Amber", "Blue", "Cyan", "Denim", "Emerald", "Fuchsia", "Green", "Honey", "Indigo"];
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int[] Numbers = [23, 1231, 2313, 34, 3890, 245, 2452, 245245, 2544, 665, 256, 4, 6425];
            Array.Sort(Numbers);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}