using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public class MonstreFacile
    {
        
        protected De de;
        protected int Damage;
        protected int NombreDePoints;
        public bool IsAlive { get; protected set; }

        public MonstreFacile()
        {
            NombreDePoints = 1;
            Damage = 10;
            IsAlive = true;
            de = new De();
        }

        public virtual void Attaque(Joueur joueur)
        {
            int resultJoueur = de.LanceLeDe();
            int resultMonstre = de.LanceLeDe();
            if (resultMonstre > resultJoueur)
            {
                Console.WriteLine("Le monstre attaque");
                joueur.TakeDamage(Damage);
            }
            else
            {
                Console.WriteLine("Le monstre a raté son attaque");
            }
        }

        public int Die()
        {

            IsAlive = false;
            Console.WriteLine("Vous avez tué un monstre");
            return NombreDePoints;
        }
    }
}
