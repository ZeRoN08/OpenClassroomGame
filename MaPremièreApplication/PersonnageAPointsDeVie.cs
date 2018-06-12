using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public abstract class PersonnageAPointsDeVie : Personnage
    {
        protected int Health = 150;
        Random random = new Random();


        public override bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }
        public int LanceLeDe(int NombreDeFace)
        {
            int result = random.Next(1, NombreDeFace+1);
            return result;
            
        }


    }
}
