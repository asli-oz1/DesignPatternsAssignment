using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src.Indirimler
{
    public class IndirimFactory
    {
        public IIndirim IndirimOlustur(string tip)
        {
            if (tip == "ogrenci")
                return new OgrenciIndirimi();

            if (tip == "premium")
                return new PremiumIndirimi();

            if (tip == "yilbasi")
                return new YilbasiIndirimi();

            if (tip == "ogretmen")
                return new OgretmenIndirimi();

            return null;
        }
    }
}
