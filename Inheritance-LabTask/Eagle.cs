using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LabTask
{
    internal class Eagle:Birds
    {
        public Eagle(string name, string color, byte numberOfFeet)
        {
            Name = name;
            Color = color;
            NumberOfFeet = numberOfFeet;
        }
        public void Fly()
        {
            Console.WriteLine("Qartal ucur");
        }
    }
}
