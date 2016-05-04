using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lambda
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();

            return a / b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> sub = (a, b) => a - b;
            Func<int, int, int> mul = (a, b) => a * b;
            Func<int, int, int> div = (a, b) => 
            {
                if (b == 0) throw new DivideByZeroException();
                return a / b;
            };
        }
    }
}
