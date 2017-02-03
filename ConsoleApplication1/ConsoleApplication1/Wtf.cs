using System;

namespace ConsoleApplication1
{
    class Wtf
    {
        static void Main(string[] args)
        {
            IntTester intTester = new IntTester(5);
            Console.WriteLine(intTester.TestInt);
            intTester.TestInt = 10;
            Console.WriteLine(intTester.TestInt);
            Console.ReadLine();
        }
    }
}