using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LabTask
{
    internal class Chicken : Birds
    {
        public Chicken(string name, string color, byte numberOfFeet)
        {
            Name = name;
            Color = color;
            NumberOfFeet = numberOfFeet;
        }
        public void Walk()
        {
            Console.WriteLine("Toyuq yeriyir");
        }
    }
}
