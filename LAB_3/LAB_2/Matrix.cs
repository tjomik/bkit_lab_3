
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class Matrix<T>

    {
        int maxX;
        int maxY;
        int maxZ;
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        IMatrixCheckEmpty<T> checkEmpty;
        public Matrix(int x, int y, int z, IMatrixCheckEmpty<T> checkEmptyParam)
        {
            this.maxX=x;
            this.maxY=y;
            this.maxZ=z;
            this.checkEmpty = checkEmptyParam;
        }
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (_matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.checkEmpty.GetEmptyElement();
                }
            }
            set
            {
                CheckBounds(x,y,z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);

            }
        }
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x > maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }

            if (y < 0 || x > maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }

            if (z < 0 || z > maxZ)
            {
                throw new ArgumentOutOfRangeException("z", "z=" + z + " выходит за границы");
            }
        }
        string DictKey(int x, int y, int z)
        {
            string str = x.ToString() + "_" + y.ToString() + "_" + z.ToString();
            return str;
        }
        public override string ToString()
        {

            StringBuilder b = new StringBuilder();
            for (int k = 0; k < maxZ; k++)
            {
                b.Append("При z=" + (k+1) + "\n");

                for (int j = 0; j < maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < maxX; i++)
                    {
                        if (i > 0) b.Append("\t");
                        if (!this.checkEmpty.CheckEmptyElement(this[i, j, k])) b.Append(this[i, j, k].ToString());
                        else b.Append(" - ");
                        
                    }
                    b.Append("]\n");
                }
                
               
            }
            return b.ToString();
        }
    }
}