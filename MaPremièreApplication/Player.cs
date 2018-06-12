using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    class Player : PersonnageAPointsDeVie
    {
        private De de;
        

        public override void Attack(Personnage personnage)
        {
            int resultPlayer = de.LanceLeDe();
            int resultMonster = de.LanceLeDe();
            if(resultPlayer >= resultMonster)
            {
                personnage.TakeDamage(0);
            }
        }
        public override void TakeDamage(int Damage)
        {
            int bouclierResult = de.LanceLeDe();
            if(bouclierResult <= 2)
            {
                Damage = 0;
            }
            else
            {
                Health -= Damage;
            }
        }

    }
}
