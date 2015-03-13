using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random1.Calc calc = new Random1.Calc();
            Double result = calc.Add(1, 2);

            Console.WriteLine(result);
        }
    }
}
