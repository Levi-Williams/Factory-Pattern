using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class StandardMotorVehicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are now driving a standard vehicle. I didn't specify between car, truck, suv, etc.");
        }
    }
}
