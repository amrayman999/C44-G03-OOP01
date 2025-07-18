using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal interface ITypeA
    {
        //what you can write inside?
        //1. signature for methods
        void Print();
        //2. signature for properties
        public int X { get; set; }
        //3. default implemented methods (C# 8.0 and later)
        public void PrintHello()
        {
            Console.WriteLine("Say Hello");
        }


        //access modifier allowed inside?

    }
}
