using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, " + urun.Adi + " " + urun.Fiyat + "TL Sepete Eklendi!");
        }

        public void Listele(Urun[] urunler)
        {
            Console.WriteLine("\n--------Ürün Listesi--------");
            foreach (var urun in urunler)
            {                
                Console.WriteLine("\nÜrün adi: " + urun.Adi + "\nFiyatı : " + urun.Fiyat + "\nÜrün Açıklaması : " + urun.Aciklama);               
            }

        }
    }
}
