using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LambdaClosures
{
    class NumberGenerator
    {
        int number = 0;

        public int GiveNumber() => number++;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var gen = new NumberGenerator();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(gen.GiveNumber());
            }
            Console.WriteLine(new string('-', 20));

         
        }
    }
}
