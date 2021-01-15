using System;
using System.Collections;

namespace Ex10_5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "https://www.microsoft.com/ko-kr/";

            Console.WriteLine(" 회사 : {0}", ht["회사"]);   // 회사 : Microsoft
            Console.WriteLine(" URL : {0}", ht["URL"]);     // URL : https://www.microsoft.com/ko-kr/
        }
    }
}
