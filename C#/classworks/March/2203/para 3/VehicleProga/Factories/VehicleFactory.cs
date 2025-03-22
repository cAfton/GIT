using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProga.Interface;

namespace VehicleProga.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
