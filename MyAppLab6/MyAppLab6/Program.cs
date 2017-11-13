using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct A;
            A.integerInStruct = 7;
            Console.WriteLine("Structs don't need to be initialized in their definition. Since it's a value type, the variable can simply be assigned:\n" +
                "MyStruct A;\n" +
                "A.integerInStruct = 7;\n" +
                "Console.WriteLine(A.MyIntegerInStruct()) = " + A.MyIntegerInStruct() + "\n\n");

            MyClass B = new MyClass
            {
                integerInClass = 24
            };
            Console.WriteLine("Since classes are reference type, they need to be initialized:\n" +
                "MyClass B = new MyClass\n" +
                "{\n" +
                "   integerInClass = 24\n" +
                "};\n" +
                "Console.WriteLine(B.SetIntegerInClass()) = " + B.MyIntegerInClass() + "\n\n");

            Console.WriteLine("Enums are super simple since they don't need initialization nor variable assignment, and allow explicit conversion:\n" +
                "Console.WriteLine(MyEnum.TWO) = " + MyEnum.TWO + "\n(int)MyEnum.TWO = " + (int)MyEnum.TWO + "\n" +
                "Console.WriteLine(MyEnum.FOUR) = " + MyEnum.FOUR + "\n(int)MyEnum.FOUR = " + (int)MyEnum.FOUR + "\n" +
                "Console.WriteLine(MyEnum.SIX) = " + MyEnum.SIX + "\n(int)MyEnum.SIX = " + (int)MyEnum.SIX + "\n" +
                "Console.WriteLine(MyEnum.EIGHT) = " + MyEnum.EIGHT + "\n(int)MyEnum.EIGHT = " + (int)MyEnum.EIGHT);

            Console.ReadKey();
        }

        struct MyStruct
        {
            public int integerInStruct;
            public int MyIntegerInStruct()
            {
                return integerInStruct;
            }
        }

        class MyClass
        {
            public int integerInClass;
            public int MyIntegerInClass()
            {
                return integerInClass;
            }
        }

        enum MyEnum
        {
            ONE = 1, TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9
        }
    }    
}
