using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src.Indirimler
{
    public class YilbasiIndirimi : IIndirim
    {
        public double Hesapla(double toplamFiyat)
        {
            return toplamFiyat * 20 / 100;
        }
    }
}
