using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProga.Interface;

namespace VehicleProga.Model
{
    public class BroomBroomMotosicle : IVehicle
    {
        public double Fuel { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public void Drive()
        {
            for (; Fuel > 0; Fuel =- 5)
            {
                Console.WriteLine("Broom Broom");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Motosicle");
        }

        public override string ToString()
        {
            return $"Name of BROOMBROOMMOTOSICLE: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Price: {Price} \n";
        }
    }
}
