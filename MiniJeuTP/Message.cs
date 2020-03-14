using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class Message
    {
        public const string MONSTER_ATTACK = "Le monstre attaque";
        public const string MONSTER_DAMAGETAKEN = "Le monstre n'a pas réussi à parer et meurt";
        public const string MONSTER_MISS = "Le monstre a raté son attaque";
        public const string MONSTER_MAGIC = "Le monstre lance son attaque magique";
        public const string PLAYER_ATTACK = "Vous attaquez";
        public const string PLAYER_MISS = "Vous avez raté votre coup";
        public const string PLAYER_DAMAGETAKEN = "Vous subissez des dégâts";
        public const string PLAYER_BLOCK = "Vous bloquez l'attaque du monstre avec succès";
        public const string PLAYER_NOBLOCK = "Vous ne réussissez pas à bloquer l'attaque du monstre";
        public const string COMBAT = "Le combat commence !";

    }
}
