using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Trike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a trike! I can't decide if they are really cool or just a worse version of both a car and a motorcycle...");
        }
    }
}
