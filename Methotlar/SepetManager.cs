﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. sepete eklendi:"+urun.Adi);


        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi:"+ urunAdi);
        }
    }
}
