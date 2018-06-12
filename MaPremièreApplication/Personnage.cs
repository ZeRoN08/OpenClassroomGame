using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public abstract class Personnage
    {
        Random random = new Random();

        public int LanceLeDe()
        {
            int result = random.Next(1, 7);
            return result;
        }

        public abstract bool IsAlive { get; }

        public abstract void Attack(Personnage personnage);

        public abstract void TakeDamage(int Damage);
        
        
    }
}
