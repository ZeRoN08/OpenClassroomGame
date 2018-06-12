using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public class Monster : Personnage
    {
        protected De de;

        protected bool m_IsAlive;
        public override bool IsAlive { get { return m_IsAlive; } }
        protected int Damage;

        public Monster()
        {
            m_IsAlive = true;
            Damage = 10;
        }

        public override void Attack(Personnage personnage)
        {
            int resultPlayer = de.LanceLeDe();
            int resultMonster = de.LanceLeDe();
            if (resultPlayer >= resultMonster)
            {
                personnage.TakeDamage(Damage);
            }
        }
        public override void TakeDamage(int Damage)
        {
            m_IsAlive = false;
        }

    }
}
