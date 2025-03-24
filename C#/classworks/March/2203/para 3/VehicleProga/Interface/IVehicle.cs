using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProga.Interface
{
    public interface IVehicle
    {
        string Name { get; set; }

        double Weight { get; set; }

        double Price {  get; set; }
        void Drive();
    }
}
