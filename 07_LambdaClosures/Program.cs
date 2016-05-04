using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LambdaClosures
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Func<int>> getGenerator = () =>
            {
                int number = 0;
                Func<int> giveNumberFunc = () => number++;

                return giveNumberFunc;
            };

            var giveNumber = getGenerator();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(giveNumber());
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
