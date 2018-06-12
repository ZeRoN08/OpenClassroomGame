using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    class HardMonster : Monster
    {
        private int DamageSort;

        public HardMonster()
        {
            DamageSort = 5;
            Damage = 20;
            m_IsAlive = true;
            de = new De();
        }
        public override void Attack(Personnage personnage)
        {
            base.Attack(personnage);
            int result = de.LanceLeDe();
            if(result != 6)
            {
                personnage.TakeDamage(result * DamageSort);
            }
        }
    }
}
