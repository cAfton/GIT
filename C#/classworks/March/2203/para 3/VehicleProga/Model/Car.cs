using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProga.Interface;

namespace VehicleProga.Model
{
    public class Car : IVehicle
    {
        public double Fuel {  get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public void Drive()
        {

        }

        public override string ToString()
        {
            return $"Name of CAR: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Price: {Price}\n";
        }
    }
}
