using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;

namespace LAB_2
{
    class SimpleList<T>  
        where T : IComparable
    {
        protected SimpleListItem<T> first = null;
        protected SimpleListItem<T> last= null;

        int _count;
        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }

        public void Add(T element)
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.Count++;

            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;
            }
            else
            {
                this.last.Next = newItem;
                this.last = newItem;
            }
        }

        public SimpleListItem<T> GetItem(int number)
        {
            if (number < 0 || number > Count)
            {
                throw new Exception("Выход за границу индекса");
            }
            SimpleListItem<T> current = this.first;
            int i = 0;
            while (i < number)
            {
                current = current.Next;
                i++;
            }
            return current;
        }
        public T Get(int number)
        {
            return GetItem(number).Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low+high)/2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }
        public void Sort()
        {
            Sort(0, this.Count - 1);
        }
        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.Data;
            ci.Data = cj.Data;
            cj.Data = temp;
        }

    }
}