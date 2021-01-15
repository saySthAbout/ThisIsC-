using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz10_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
        }
    }
}
