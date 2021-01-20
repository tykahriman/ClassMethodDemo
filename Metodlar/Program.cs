using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyat = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {urunAdi,aciklama};

            foreach(string var in meyveler)
            {
                Console.WriteLine(var);                
            }


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 6;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 15;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyat);               
            }

            Console.WriteLine("----------Metotlar------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Listele(urunler);    
           
                     
        }               
    }
}
