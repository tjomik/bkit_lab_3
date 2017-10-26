
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class Rectangle : Figure, IPrint
    {
        protected double width, height;
        public Rectangle(double a, double b)
        {
            width = a;
            height = b;
            Type = "Прямоугольник";
        }
        public override double FindArea()
        {
            return width * height;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }



    }
}