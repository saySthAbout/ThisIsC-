using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 0xF0 | 0x0F;

            Console.WriteLine($"a = 0x{a:X}");   // a는 0xFF 이다.

            //int a = 0xF3 | 0x05;

            //Console.WriteLine($"a = 0x{a:X}");
        }
    }
}
