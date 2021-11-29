using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_29112021_55_OOP_EncapsulationOrnek
{
    class Daire
    {
        //özellikler
        public double Yaricap { get; set; }
        private double cap = 0;
        public double Cap
        {
            get
            {
                if (Yaricap>0d)
                {
                    cap = Yaricap*2;
                }
                return cap;
            }
        }
        public double PiSayisi { get; set; }
        //constructorlar
        public Daire()
        {
            PiSayisi = 3;

        }
        public Daire(double disardanPiSayisi)
        {
            PiSayisi = disardanPiSayisi;
        }
        //metotlar
        public double AlanHesapla()
        {
            return PiSayisi * Math.Pow(Yaricap,2);
        }
        public double CevreHesapla()
        {
            return PiSayisi * Yaricap * 2;
        }

    }
}
