using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_2
{
    class SimpleListItem<T>
    {
        public T Data { get; set; }
        public SimpleListItem<T> Next { get; set; }
        public SimpleListItem(T param)
        {
            this.Data = param;
        }
    }
}