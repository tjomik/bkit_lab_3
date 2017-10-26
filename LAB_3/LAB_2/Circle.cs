using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class Circle: Figure, IPrint
    {
        double radius;
        public Circle(double a)
        {
            radius = a;
            Type = "Окружность";
        }
        public override double FindArea()
        {
            return Math.PI * radius * radius;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}