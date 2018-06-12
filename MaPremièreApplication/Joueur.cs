using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public class Joueur
    {
        private De de;
        public int Health { get; private set; }
        public int Score { get; set; }
        public int NumberOfKillHard { get; private set; }
        public int NumberOfKillEasy { get; private set; }

        public Joueur(int health)
        {
            Health = health;
            Score = 0;
            de = new De();
            NumberOfKillEasy = 0;
            NumberOfKillHard = 0;
        }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public void Attack(MonstreFacile monstre)
        {
            int resultJoueur = de.LanceLeDe();
            int resultMonstre = de.LanceLeDe();
            if (resultJoueur >= resultMonstre)
            {
                Console.WriteLine("Vous Avez Attaquer un monstre ");
                Score += monstre.Die();
                if (monstre is MonstreDifficile)
                {
                    NumberOfKillHard++;
                }
                else               
                {
                    NumberOfKillEasy++;
                }
            }
            else
            {
                Console.WriteLine("Le monstre esquive l'attaque");
            }
        }

        public void TakeDamage(int Damage)
        {
            int bouclierResult = de.LanceLeDe();
            if(bouclierResult <= 2)
            {
                Damage = 0;
                Console.WriteLine("Le Joueur a été protégé grâce au bouclier");
            }
            else
            {
                Health -= Damage;
                Console.WriteLine("Le Joueur a été toucher et a perdu " + Damage);
                Console.WriteLine("Le Joueur a maintenant " + Health + " HP");
            }
           
        }
    }
}
