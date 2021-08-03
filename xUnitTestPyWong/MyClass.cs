using System;
using System.Threading;

namespace xUnitTestPyWong
{
    public class MyClass
    {
        String a = "diu";

        public MyClass()
        {
            Console.WriteLine("Constructor...");
        }

        public void dnlm()
        {
            a = "hahaha";

            // test unit test delay
            Thread.Sleep(5000);
            a = "Hello World!";
        }

        public String getA()
        {
            return a;
        }

        static void Main()
        {
            Console.WriteLine("Hello Ridiculands");
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.a);
            myClass.dnlm();
            Console.WriteLine(myClass.a);
        }
    }
}
