using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProga.Interface;
using VehicleProga.Model;

namespace VehicleProga.Factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            return new Car() {Name = name, Weight = weight, Price = price};
        }
    }
}
