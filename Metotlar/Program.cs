﻿
using Metotlar;


//Do not repeat yourself - DRY - Clean Code - Best Practice

Urun urun1 = new Urun();   
urun1.Adi = "Elma";
urun1.Fiyat = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyat = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1,urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyat);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-------------------------");
}

Console.WriteLine("---------------Metotlar----------------");

//instance - örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut","Yeşil armut",12,9);
sepetManager.Ekle2("Elma","Yeşil elma",12,8);
sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12,7);

