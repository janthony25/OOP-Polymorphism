using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A dog is also: Canine, Animal, Orgranism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car,  bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("That Car is now moving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("That Bicycle is now moving!");
        }

    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("That Boat is now moving!");
        }
    }
}