using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LambdaForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addMethod = delegate (int a, int b)
            {
                return a + b;
            };

            Func<int, int, int> addOperator = (a, b) => 
            {
                return a + b;
            };

            Func<int, int, int> addExpression = (a, b) => a + b;
        }
    }
}
