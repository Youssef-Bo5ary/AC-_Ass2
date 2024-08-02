using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Ass2
{
    internal class FixedSizeList<T> 
    {
        
        public  T[] list {  get; set; }
        public int size {  get; set; }
        public  int Capacity { get; set; }


        public FixedSizeList(int capacity)
        {
           Capacity = capacity;
            list = new T[capacity];
            size = 0;
        }


        public  void ADD( T value)
        {
            if (size <= Capacity)
            {
                list[size] = value;
                size ++;
            }
            else { throw new ArgumentOutOfRangeException("the list is already full"); }
        }

        public  T Get( int size)
        {
            if (size > 0 && size <= Capacity)
            { return list[size]; }
            else { throw new ArgumentOutOfRangeException("this index out of range"); }
            
        }
    }
}
