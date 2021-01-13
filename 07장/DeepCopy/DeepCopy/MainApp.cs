using System;

namespace DeepCopy
{

    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");

            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");

                // ICloneable.Clone() 메소드
                // "깊은 복사" 기능을 가질 클래스가 .NET 프레임워크의 다른 유틸리티 클래스나 다른 프로그래머가 작성한 코드와
                // 호환되도록 하고 싶다면 ICloneable을 상속하도록 하는 것이 좋습니다. ICloneable 인터페이스는 Clone() 메소드 하나만 갖고 있습니다.
            }
        }
    }
}
