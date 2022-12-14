using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generics.Services
{
    internal class PrintService
    {
        private int[] _Values = new int[10];
        private int _Count = 0;

        public void AddValue(int value)
        {
            if (_Count == 10) { throw new InvalidOperationException("PrintService is full !!"); }
            _Values[_Count] = value;
            _Count++;
        }

        public int ValueFirst()
        {
            if (_Count == 0) { throw new InvalidOperationException("PrintService is empty !!"); }
            return _Values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _Count-1; i++)
            {
                Console.Write(_Values[i] + ", ");

            }
            if (_Count >0)
            {
                Console.Write(_Values[_Count-1]);
            }
            Console.WriteLine("]");

        }
       
    }
}
