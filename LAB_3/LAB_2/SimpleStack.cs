using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class SimpleStack<T>: SimpleList<T> where T: IComparable
    {
        public void Push(T element)
        {
            Add(element);
      
        }
        public T Pop()
        {
            T Result = default(T);
            if (Count == 0) return Result;
            if (Count == 1)
            {
                Result = this.first.Data;
                this.first = null;
                this.last = null;
            }
            else
            {
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);

                Result = newLast.Next.Data;
                this.last = newLast;
                newLast.Next = null;
            }
            this.Count--;
            return Result;
        }
    }
}