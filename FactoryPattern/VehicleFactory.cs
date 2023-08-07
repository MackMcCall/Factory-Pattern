using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheels)
        {
            switch (wheels)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 16:
                case 18:
                    return new BigRig();
                default:
                    return new Car();
            }
        }
        
    }
}
