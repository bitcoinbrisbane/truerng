using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create random class with port 3
            RandomFromTrueRNG random = new RandomFromTrueRNG(3);

            Byte[] randombytes = random.fill(20);

            Debug.Assert(randombytes.Length == 20);
        }
    }
}
