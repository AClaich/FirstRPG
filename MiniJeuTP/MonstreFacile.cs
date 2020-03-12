using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class MonstreFacile : Monstre
    {
        public int VictoryPoint { get; private set; }
        public bool IsAlive { get; set; }

        public int Jet()
        {
            return De.LancerD6();
        }

    }
}
