using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LambdaClosures
{
    class Program
    {
        static Func<int> GetGenerator()
        {
            int number = 0;
            Func<int> giveNumber = () => number++;

            return giveNumber;
        }

        static void Main(string[] args)
        {

            var giveNumber = GetGenerator();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(giveNumber());
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
