using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MiniJeuTP
{
    class Wait
    {
        public static void TimeWait(int ms)
        {
            Thread.Sleep(ms);
        }

        public static void WaitKey(ConsoleKey key)
        {
            if (!Console.ReadKey(true).Key.Equals(key))
                Wait.WaitKey(key);
        }
    }
}
