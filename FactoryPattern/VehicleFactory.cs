using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            if(numberOfTires == 1)
            {
                return  new Unicycle();
            }
            if(numberOfTires == 2) 
            { 
                return new Motorcycle();
            }
            if(numberOfTires == 3) 
            { 
                return  new Trike();
            }
            if(numberOfTires == 4) 
            { 
                return new StandardMotorVehicle();
            }
            else { return new StandardMotorVehicle(); }
            
            throw new NotImplementedException();
        }
    }
}
