using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MiniJeuTP
{
    class Wait
    {
        public static bool TimeWait(int ms)
        {
            Thread.Sleep(ms);
            return true;
        }

        public static void WaitKey(ConsoleKey key)
        {
            if (!Console.ReadKey(true).Key.Equals(key))
                Wait.WaitKey(key);
        }
    }
}
