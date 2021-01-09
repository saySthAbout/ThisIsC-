using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine($"num : {num++}"); // 후위 증가연산자는 출력을 한 뒤에 변수의 값을 1 증가시킨다. // num : 10

            // 출력후 num의 값은 11이 되었다.

            Console.WriteLine($"num : {++num}"); // 전위 증가연산자는 출력을 하기 전에 변수의 값을 1 증가시킨다. // num : 12
            
        }
    }
}
