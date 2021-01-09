using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 10;
            string b = a == 0 ? "가나다" : "ABC";

            Console.WriteLine($" b : {b}");     //  b : ABC
        }
    }
}
