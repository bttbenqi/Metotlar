using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };
            //type safe
            foreach (var product in urunler)
            {
                Console.WriteLine("product.Adi");
                Console.WriteLine("product.Fiyatı");
                Console.WriteLine("product.Aciklama");
                Console.WriteLine("----------");
            }

            Console.WriteLine("-----------------Metotlar--------");

            //Console.WriteLine("Hello World!");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            sepetManager.Ekle2("armut", "yesil armut", 12, 78);
            sepetManager.Ekle2("elma", "yesil elma", 12,77);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 44);


        }
    }
}


//dont repeat yourself 
