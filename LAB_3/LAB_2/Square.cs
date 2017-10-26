using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class Square: Rectangle, IPrint
    {
        public Square(double a) : base (a,a)
        {
            Type = "Квадрат";
        }
        
        
    }
}