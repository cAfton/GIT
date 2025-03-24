using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProga.Interface;

namespace VehicleProga.Model
{
    public class Bicycle : IVehicle
    {
        public double Energy { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public void Drive()
        {
            Console.WriteLine("do sport");
        }
        public override string ToString()
        {
            return $"Name of BICYCLE: {Name} \n" +
                $"Weight: {Weight} \n" +
                $"Price: {Price} \n";
        }
    }
}
