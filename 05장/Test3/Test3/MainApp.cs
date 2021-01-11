using System;

namespace Test3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1번을 while문으로 변환
            //int i = 0;

            //while (i < 5)
            //{
            //    int j = 0;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            // 1번을 do-while문으로 변한
            //int i = 0;

            //do
            //{
            //    int j = 0;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //while (i < 5);

            // 2번을 while문으로 변환
            //int i = 4;

            //while (i >= 0)
            //{
            //    int j = 0;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}

            // 2번을 do-while문으로 변환
            int i = 5;

            do
            {
                int j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                }
                while (j < i);
                Console.WriteLine();
                i--;
            }
            while (i > 0);
        }
    }
}
