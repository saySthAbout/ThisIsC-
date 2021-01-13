using System;

namespace Quiz
{
    public static class stringExtension
    {
        public static string Append(this string org, string appendStr)
        {
            return org + appendStr;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));     // "Hello, World!" 출력
        }
    }
}
