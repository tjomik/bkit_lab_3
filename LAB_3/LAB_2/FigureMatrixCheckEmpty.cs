using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class FigureMatrixCheckEmpty: IMatrixCheckEmpty <Figure>
    {
        public Figure GetEmptyElement()
        {
            return null;
        }
        public bool CheckEmptyElement(Figure element)
        {
            bool result = false;
            if (element == null) result = true;
            return result;
        }

    }
}