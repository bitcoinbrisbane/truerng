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
            CreateRng(3);

            Byte[] randombytes = new Byte[20];

            int nbytes = Fill(randombytes, 20);

            DeleteRng();
        }
    }
}
