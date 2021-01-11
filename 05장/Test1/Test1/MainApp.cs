using System;

namespace Test1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
