using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hoursofSleep = int.Parse(Console.ReadLine());

            if (hoursofSleep > 8)
            {
                Console.WriteLine("Hello, " + name + ".");
                Console.WriteLine("You are well rested.");
            }
            else
            {
                Console.WriteLine("Hello, " + name + ".");
                Console.WriteLine("You need more sleep.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
