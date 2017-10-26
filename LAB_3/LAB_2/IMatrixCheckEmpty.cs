using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
   public interface IMatrixCheckEmpty<T>
    {
        T GetEmptyElement();

        bool CheckEmptyElement(T element);
    }
}