using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Test
    {
        interface IMyInterface
        {
            void method1();
            string myProperty
            {
                get;
                set;
            }

        }
        interface IMyInterface1
        {
            void method1();
            string myProperty
            {
                get;
                set;
            }

        }
        interface IMyInterface2 : IMyInterface, IMyInterface1
        {
            void method1();
            string myProperty
            {
                get;
                set;
            }

        }

        abstract class MyAbsClass
        {
            static int t;
            public MyAbsClass()
            {

            }

            abstract class MyAbsClass1 : MyAbsClass
            {
                static int t;
                public MyAbsClass1()
                {

                }



            }
        }
    }
}
