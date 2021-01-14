using System;

namespace Ex7_2
{
    class A
    {

    }
    class B : A
    {

    }

    class C
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A c = new B();
            B d = (B)new A(); // 여기서 에러난다. // B d = (B)new A(); --> 이렇게 casting 연산자를 이용해 해결할 수 있다.
        }
    }
}
