using System;
using System.Collections.Generic;
using System.Threading;

namespace MiniJeuTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First RPG !");
            Thread.Sleep(1000);
            Console.WriteLine("Appuyer sur la touche entrée " +
                "pour continuez");
            Wait.WaitKey(ConsoleKey.Enter);
            Console.Clear();

            List<string> choices = new List<string>();
            choices.Add("Jouer");
            choices.Add("Quitter");

            uint index = 0;

            HUD.Menu(choices, ref index);

            int[] result = { 0, 0 };
            
            GameOn(ref result);

            Console.WriteLine("Bravo !!! Vous avez tué " +
                            result[0] + " monstres faciles et " +
                            result[1] + " monstres difficiles. " +
                            "Vous avez " + Resultat(result) + " points.");
        }

        private static int[] GameOn(ref int[] result)
        {
            Joueur player = new Joueur();

            while (player.HealthPoint >= 1)
            {
                int choixMonstre = De.LancerD2();

                if (choixMonstre == 1)
                {
                    MonstreFacile monster = new MonstreFacile();
                    CombatFacile(monster, ref player);
                    result[0]++;
                }
                else
                {
                    MonstreDifficile monster = new MonstreDifficile();
                    CombatDifficile(monster, ref player);
                    result[1]++;
                }
            }

            return result;
        }

        private static int Resultat(int[] result)
        {
            return result[0] + result[1] * 2;
        }

        private static void CombatFacile(MonstreFacile monster, ref Joueur player)
        {
            while (monster.IsAlive)
            {
                // first strike : by player
                if (player.Jet() < monster.Jet())
                {
                    // second strike : by the monster
                    if (player.Jet() < monster.Jet())
                        if (player.Shield < monster.Jet())
                            player.Damage(10);
                }
                else
                {
                    monster.IsAlive = false;
                }
            }
        }

        private static void CombatDifficile(MonstreDifficile monster, ref Joueur player)
        {
            while (monster.IsAlive)
            {
                // first strike : by player
                if (player.Jet() < monster.Jet())
                {
                    // second strike : by monster
                    if (player.Jet() < monster.Jet())
                        if (player.Shield < monster.Jet())
                            player.Damage(10);
                    // magic strike : by monster
                    int magic = monster.Jet();
                    player.Damage(magic == 6 ? 0 : magic * 5);
                }
                else
                {
                    monster.IsAlive = false;
                }


            }
        }
    }
}
