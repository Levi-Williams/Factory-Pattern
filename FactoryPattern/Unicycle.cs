﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Unicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are on a unicycle, very unique choice!");
        }
    }
}
