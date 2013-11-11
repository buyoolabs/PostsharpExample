using PostsharpExample.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostsharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            //Method3();
            Method4(10000);
            Method4(10000);
            Method4(20000);
            Method4(20000);
            Console.Read();
        }

        [Trace("A")]
        private static void Method1()
        {
            System.Threading.Thread.Sleep(1000);
        }

        [Trace]
        private static void Method2()
        {
            System.Threading.Thread.Sleep(2000);
        }

        [Trace]
        private static void Method3()
        {
            //string str = "10000000";
            //Int16 number;

            //number = Convert.ToInt16(str);

            //Console.WriteLine(number);
        }

        [Cache]
        [Trace]
        private static int Method4(int numLoop)
        {
            int numLoops = 0;

            Console.WriteLine("calculando valor, no esta cacheado");

            for (int i = 0; i < numLoop; i++)
            {
                numLoops = numLoops + 1;
            }

            return numLoops;
        }
    }
}
