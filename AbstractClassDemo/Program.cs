using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.ReadLine();
        }
    }

    public class Vehicle : Test
    {
        public string VINNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        public void GetTest()
        {
            Test test = new Test();
            something = "";
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;

    }
}
