﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.Abstract
{
    public class Refrigerator : Appliance
    {
        public override void TurnOff()
        {
            Console.WriteLine("Холодильник Выключение");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Холодильник Включение");
        }
    }
}
