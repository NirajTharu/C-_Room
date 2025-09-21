// Abstraction is the process to redeuce the complexity by providing a simplified view of an object or system, focusing on its essential features and behaviours.

using System;

namespace Abstraction
{
    abstract class Living_Being
    {
        // Abstract Method(do not hava body)
        public abstract void Photosynthesis();
        public void Sleep()
        {
            Console.WriteLine("Sleeps at Night.");
        }
    }
    // Inherit form the Living_Being
    class Planet : Living_Being
    {
        public override void Photosynthesis()
        {
            Console.WriteLine("Plant prepare their food their self by using sunlight.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Planet p = new Planet();
            p.Sleep();
            p.Photosynthesis();
        }
    }

}