using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIPracticeAssignment1_DesmondRagsdale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Createcar details
            car myCar = new car();

            //Setting Properties

            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2020;
            myCar.Color = "Blue";
            myCar.Mileage = 5000;

            //Showing car details

            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Color: {myCar.Color}");
            Console.WriteLine($"Mileage: {myCar.Mileage}");
        }
    }
}
