using System;
using System.Collections.Generic;
using System.Text;

namespace TanghalLab
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int count = 0; count < 6; count++)
            {
                Thread.Sleep(1500);

                Thread current = Thread.CurrentThread;

                Console.WriteLine(
                    "Name of Thread: " + current.Name +
                    " Process = " + count
                );
            }
        }
    }
}
    
