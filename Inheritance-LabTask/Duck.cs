using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LabTask
{
    internal class Duck:Birds
    {
        public Duck(string name, string color, byte numberOfFeet)
        {
            Name = name;
            Color = color;
            NumberOfFeet = numberOfFeet;
        }
        public void Swim()
        {
            Console.WriteLine("Ordek ucur");
        }
    }
}
