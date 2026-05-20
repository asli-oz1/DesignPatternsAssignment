using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src.Yapisal
{
    public class KuponDecorator
    {
        public double KuponUygula(double fiyat)
        {
            Console.WriteLine("Kupon indirimi uygulandı (%5)");

            return fiyat - (fiyat * 5 / 100);
        }
    }
}