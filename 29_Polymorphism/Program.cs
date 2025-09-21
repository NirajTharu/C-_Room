// Polymorphism -> Means "Many forms" and it occurs when we have many classes that are realted to each other by inheritance.
// C# provides an option to override the base class method, by adding 'virtural' keyword to the method inside the base class and by using 'override' keyword for each derived class methods.

using System;

namespace Polymorphism
{
    class Rocket
    {
        public string orbit_Velocity = "7.9 km/s";
        public string escape_Velocity = "11.19km/s";
        public virtual void Works_By()
        {
            Console.WriteLine("Rockts Works by Newton's third law of Motion.");
        }
    }
    class SpaceX : Rocket
    {
        private string Name = "Falcon 9";
        private string Company_Of_Origin = "SpaceX";
        public override void Works_By()
        {
            Console.WriteLine("The Name of the Rocket is " + Name + "The company of origin is " + Company_Of_Origin);
            Console.WriteLine("A reusable, medium-lift rocket known for its high launch cadence, reliable performance, and ability to deliver payloads to orbit.");
        }
    }
    class Blue_Origin : Rocket
    {
        private string Name = "New Shepard";
        private string Company_Of_Origin = "Blue Origin";
        public override void Works_By()
        {
            Console.WriteLine("The Name of the Rocket is " + Name + " The company of origin is " + Company_Of_Origin);
            Console.WriteLine("This is a fully reusable, suborbital rocket system named after the first American in space, Alan Shepard.");
        }
    }
    class Progrm
    {
        static void Main(string[] args)
        {
            Rocket r = new Rocket();
            SpaceX x = new SpaceX();
            Blue_Origin b = new Blue_Origin();
            Console.WriteLine("The orbit velocity of the rocket should be " + r.orbit_Velocity + " to enter the earth's orbit.");
            Console.WriteLine("Escape Velocity " + r.escape_Velocity + " is the higher speed required to completely overcome Earth's gravitational pull and leave the planet.");
            x.Works_By();
            b.Works_By();
        }
    }
}