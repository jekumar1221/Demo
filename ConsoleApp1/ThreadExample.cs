using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    public class ThreadExample
    {
        public static void MainThread() {
            Thread th = new Thread(Number.PrintNumber);//   Thread th = new Thread(new ThreadStart( Number.PrintNumber))
            Thread th2 = new Thread(new ParameterizedThreadStart(Number.PrintNumbers));
           
            th.Start();
           object target= Console.ReadLine();
            th2.Start(target);


        }
        

    }

    public class Number
    {

        public static void PrintNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers(object number)
        {

            int num;
            if (int.TryParse(number.ToString(), out num))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
