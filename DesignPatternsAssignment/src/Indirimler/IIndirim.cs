using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src.Indirimler
{
    public interface IIndirim
    {
        double Hesapla(double toplamFiyat);
    }
}