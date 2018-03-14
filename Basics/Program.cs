using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            const byte sample1 = 0x3A;

            uint sample2 = 58;

            int heartRate = 85;

            double deposits = 135002796;

            float acceleration = 9.800f;

            float mass = 14.6f;

            double distance = 129.763001;

            bool lost = true;

            bool expensive = true;

            int choice = 2;

            const char integral = '\u222B';

            string greeting = "Hello";

            string name = "Karen";

            Console.WriteLine(sample1 == sample2 ? "The samples are equal." : "The samples are not equal.");

            Console.WriteLine((heartRate >= 40 & heartRate <= 80)
                ? "Heart rate is normal."
                : "Heart rate is not normal.");

            Console.WriteLine(deposits >= 100000000 ? "You are exceedingly wealthy." : "Sorry you are so poor.");

            var force = mass * acceleration;

            Console.WriteLine("force = " + force);
            Console.WriteLine(distance + " is the distance.");

            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.WriteLine(integral + " is an integral");

            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i= " + i);
            }

            int age = 0;

            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }

            Console.WriteLine(greeting + " " + name);

            Console.ReadLine();
        }
    }
}

