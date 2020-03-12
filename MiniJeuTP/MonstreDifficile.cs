using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class MonstreDifficile : Monstre
    {
        public int VictoryPoint { get; private set; }
        public bool IsAlive { get; set; }

        public MonstreDifficile()
        {
            this.VictoryPoint = 2;
            this.IsAlive = true;
        }

        public int Jet()
        {
            return De.LancerD6();
        }
    }
}
