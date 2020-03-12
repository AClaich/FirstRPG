using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class De
    {
        private static Random random = new Random();
        public static int LancerD6()
        {
            return random.Next(1,7);
        }

        public static int LancerD2()
        {
            return random.Next(1, 3);
        }

    }
}
