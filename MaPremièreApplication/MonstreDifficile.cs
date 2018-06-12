using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public class MonstreDifficile : MonstreFacile
    {
        private int DamageSort; 

        public MonstreDifficile()
        {
            NombreDePoints = 2;
            Damage = 20;
            DamageSort = 5;
            IsAlive = true;
            de = new De();
        }
        public override void Attaque(Joueur joueur)
        {
            base.Attaque(joueur);
            int result = de.LanceLeDe();
            if (result != 6)
            {
                Console.WriteLine("Le monstre vient de lancer un sort pour " + result * DamageSort + " dégats.");
                joueur.TakeDamage(result * DamageSort);
            }
        }
    }

}
