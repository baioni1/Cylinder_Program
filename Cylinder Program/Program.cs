using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cylinder Calculator 1.0");

            Console.WriteLine("Enter the Cylinder's Radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            Console.WriteLine("Enter the Cylinder's Height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.141592654;
            double volume = pi * radius * height;
            double surfaceArea = 2 * pi * radius * (radius * height);

            Console.WriteLine("The Cylinder's volume is: " + volume + " cubic units. ");
            Console.WriteLine("The Cylinder's surface area is:" + surfaceArea + " square units");

            Console.ReadKey(); 
                
        }
    }
}
