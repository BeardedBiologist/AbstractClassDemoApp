using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufactoror { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
    }
}