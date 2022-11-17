using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_ComGenerics
{
    internal class PrintService<T>
    {
        private T[] _Values = new T[10];
        private int _Count=0;


        public void AddValue(T value)
        {
            if (_Count ==10)
            {
                throw new InvalidOperationException("PrintService is full !");
            }
            _Values[_Count] = value;
            _Count++;   
        }

        public T Fisth()
        {
            if (_Count == 0)
            {
                throw new InvalidOperationException("PrintService is Empty! ");
            }
            return _Values[0]; 
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _Count-1 ; i++)
            {
                Console.Write(_Values[i] + ", ");

            }
            if (_Count > 0)
            {
                Console.Write(_Values[_Count - 1]);
            }
            Console.Write("]");

        }
    }
}
