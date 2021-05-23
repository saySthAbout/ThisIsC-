﻿using System;

namespace Ex13_1
{
    delegate int MyDelegate(int a, int b);

    class MainApp
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Callback(3, 4));

            Callback = delegate (int c, int d)
            {
                return c - d;
            };

            Console.WriteLine(Callback(7, 5));
        }
    }
}
