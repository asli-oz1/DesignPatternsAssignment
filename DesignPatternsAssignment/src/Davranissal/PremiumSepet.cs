using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src.Davranissal
{
    public class PremiumSepet : ISepetStratejisi
    {
        public void BilgiGoster()
        {
            Console.WriteLine("Premium kullanıcı işlemi");
        }
    }
}
