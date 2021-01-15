using System;

namespace Ex10_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] b = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[][] times = new int[2][];

            times[0] = new int[2] { (a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0]), (a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1]) };
            times[1] = new int[2] { (a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0]), (a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1]) };

            foreach(int[] arr in times)
            {
                foreach(int i in arr)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            } 
            // 29 20
            // 13 30
        }
    }
}
