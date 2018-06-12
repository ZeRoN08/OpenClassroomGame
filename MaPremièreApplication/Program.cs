using System;
using System.Collections.Generic;

namespace MaPremièreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MonstreFacile monstre;
            Joueur joueur = new Joueur(150);

            while (joueur.IsAlive)
            {
                Random spawnmonstre = new Random();
                Console.WriteLine("Un monstre a spawn");
                int result = spawnmonstre.Next(1, 3);
                if(result == 1)
                {
                    monstre = new MonstreFacile();
                }
                else
                {
                    monstre = new MonstreDifficile();
                }

                while(monstre.IsAlive)
                {
                    joueur.Attack(monstre);
                    if(monstre.IsAlive)
                    {
                        monstre.Attaque(joueur);
                    }
                    if (!joueur.IsAlive)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Snif ,vous êtes mort... ");
            Console.WriteLine("Votre score final est de " + joueur.Score);
            Console.WriteLine("Vous avez tué " + joueur.NumberOfKillEasy + " mob facile et " + joueur.NumberOfKillHard + " mob difficile ");
        }
    }
}
    