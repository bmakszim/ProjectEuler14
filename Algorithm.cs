using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler14
{
    public class Algorithm
    {
        private uint counter = 0;

        public uint Run(uint i)
        {
            this.counter = 0;

            while (i != 1)
            {
                if (i % 2 == 0)
                {
                    Even(ref i);
                }
                else
                {
                    Odd(ref i);
                }
            }

            return this.counter;
        }

        private void Odd(ref uint input)
        {
            this.counter = this.counter + 1;
            input = input * 3 + 1;
        }

        private void Even(ref uint input)
        {
            this.counter = this.counter + 1;
            input = input / 2;
        }
    }
}
