using System;
using System.Collections.Generic;

namespace ClassMetotDemo{
  class MainClass {
    public static void Main (string[] args) {
      Musteri musteri_1 = new Musteri();
      musteri_1.MusteriId = 121212;
      musteri_1.MusteriTCNo = "11111111111";
      musteri_1.MusteriAd = "Serhat";
      musteri_1.MusteriSoyad = "SEVİM";
      musteri_1.MusteriTelNo = "05321234567";
      musteri_1.MusteriAdres = "Kızılay Ankara";
      musteri_1.MusteriCinsiyet = "Erkek";
      musteri_1.MusteriAciklama = "Yeni müşteri kaydı açıldı.";
      
      Musteri musteri_2 = new Musteri();
      musteri_2.MusteriId = 2323232;
      musteri_2.MusteriTCNo = "22222222222";
      musteri_2.MusteriAd = "Sedus";
      musteri_2.MusteriSoyad = "STABİLUS";
      musteri_2.MusteriTelNo = "05321234567";
      musteri_2.MusteriAdres = "Kızılay Ankara";
      musteri_2.MusteriCinsiyet = "Erkek";
      musteri_2.MusteriAciklama = "Yeni müşteri kaydı açıldı.";

      /*MusteriManager sınıfından musteriManager isimli bir instance oluşturularak  bu sınıfta yeralan MusteriEkle, MusteriListele, Müşterisi metodları çağırılıyor... 
      */
      MusteriManager musteriManager = new MusteriManager();
      
      //MusteriEkle metoduna Musteri tipinde bir parametre gönderiliyor. 
      musteriManager.MusteriEkle(musteri_1);
      musteriManager.MusteriEkle(musteri_2);
      
      musteriManager.MusteriListele();
      musteriManager.MusteriSil(musteri_2);
    }
  }
}
