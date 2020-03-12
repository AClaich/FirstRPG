using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class Joueur
    {
        public int HealthPoint { get; private set; }
        public int Shield { get; set; }

        public Joueur()
        {
            this.HealthPoint = 150;
            this.Shield = 2;
        }

        public int Jet()
        {
            return De.LancerD6();
        }

        public void Damage(int damage)
        {
            this.HealthPoint -= damage;
        }
    }
}
