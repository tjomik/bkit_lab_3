
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace LAB_2
{
    abstract class Figure: IComparable
    {
       public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        string _Type;
        public abstract double FindArea();

        public override string ToString()
        {
            return this.Type + " площадью " + this.FindArea().ToString();

        }
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.FindArea() < p.FindArea()) return -1;
            else if (this.FindArea() == p.FindArea()) return 0;
            else return 1;
        }

    }
}