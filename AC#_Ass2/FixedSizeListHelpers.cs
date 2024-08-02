using AC__Ass2;
using AC__Ass2;
using AC__Ass2;
using AC__Ass2;
using AC__Ass2;
using System;
using System;
using System;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text;
using System.Text;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading.Tasks;

internal static class FixedSizeListHelpers<T>
{
        
        public static T[] list {  get; set; }
        public static int size {  get; set; }
        public static int Capacity { get; set; }


        public static void ADD( T value)
        {
            if (size <= Capacity)
            {
            list[size] = value;
            size++;
            }
            else { throw new ArgumentOutOfRangeException("the list is already full"); }
        }

    public static T Get(int size)
    {
        if (size > 0 && size <= Capacity)
            return list[size];

    }

        public static T Get( int size)
        {
            if (size>0 && size <= Capacity)
                return list[size] ;
            
        }
}