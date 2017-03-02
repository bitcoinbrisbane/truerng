using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        [DllImport("Win32Random.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CreateRng(int port);

        [DllImport("Win32Random.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Fill(byte[] b, int size);

        [DllImport("Win32Random.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteRng();

        static void Main(string[] args)
        {
            //Check on device manager after installed with driver
            Int32 port = Convert.ToInt32(args[0]);
            Int32 length = 20;

            CreateRng(port);

            Byte[] randombytes = new Byte[length];

            int nbytes = Fill(randombytes, length);

            DeleteRng();

            Console.WriteLine("Dump to console");
            for(Int32 i = 0; i < length; i++)
            {
                Console.WriteLine(randombytes[i]);
            }

            Console.WriteLine(Convert.ToBase64String(randombytes));
            Console.Read();
        }
    }
}
