using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    internal class Fibonacci
    {
        public void Series()
        {
            int val1 = 0, val2 = 1, val3, i, n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.Write(val1 + " " + val2 + " ");
            for (i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }

        }

    }

}
