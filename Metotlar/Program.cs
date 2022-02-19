using System;

namespace Metotlar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string UrunAdi = "Elma";
            //double Fiyat = 15;
            //string Aciklama = "Amasya Elması";
            //string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.UrunAdi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 150;

            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 140;

            //bu veriler veri kaynağından gelir.
            //Database, excel, API
            Product[] urunler = new Product[]
            {
                urun1,urun2
            };
            //type-safe --> veri güvenliği
            foreach (Product item in urunler)
            {
                Console.WriteLine(item.UrunAdi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine(item.stokAdedi);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------Metotlar-------------");
            //Instance --> Örnek
            //encapsulation (kapsülleme)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Deveci Armutu",25,150);
        }
    }
}

//Don't repeat yourself --> Kendini tekrar etme!
//Clean Code
//Best Practice --> Doğru uygulama tekniği