using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremièreApplication
{
    public class De
    {
        Random random = new Random();

        public int LanceLeDe()
        {
            int result = random.Next(1, 7);
            //Console.WriteLine("Le résultat est de " + result);
            return result;
        }
    }
}
