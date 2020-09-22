using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler14
{
    class Program
    {
        static void Main(string[] args)
        {
            var alg = new Algorithm();
            uint highestCounter = 0;
            uint highestNumber = 0;

            for (uint i = 10; i <= 1000000; i++)
            {
                uint result = alg.Run(i);
                if (result > highestCounter)
                {
                    highestCounter = result;
                    highestNumber = i;
                }
            }

            Console.WriteLine(highestNumber);
            Console.Read();
        }
    }
}
