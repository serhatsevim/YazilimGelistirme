using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{  
//müşteri ile ilgili operasyonların (metodların) tanımlandığı MusteriManager class
  class MusteriManager
  {
  /*List koleksiyonu kullanılarak
    Musteri türünde musteriler adında bir değişken tanımlanıyor ve bu sınıfın constructor metodu oluşturularak sınıftan bir instance oluşturulduğunda bu listin referansının bellekte oluşturulması sağlanıyor.Bu şekilde oluşturulan referans tipte veri barındıran musteriler instance I sınıf içindeki diğer metıdlar tarafından da kullanılabiliyor. 
  */
    List<Musteri> musteriler;
    public MusteriManager(){
      musteriler = new List<Musteri>();
    }

    public void MusteriEkle(Musteri musteri)
    {      
      musteriler.Add(musteri);
      Console.WriteLine(musteri. MusteriTCNo + " " + musteri. MusteriAd + " "  + musteri.MusteriSoyad + " kaydı sisteme eklendi. \n");
    }

    public void MusteriListele(){
     foreach(var musteri in musteriler){
        Console.WriteLine(" - - - Müşteri Bilgileri - - -");
        Console.WriteLine("Id           : " + musteri.MusteriId);
        Console.WriteLine("TC Kimlik No : " + musteri.MusteriTCNo);
        Console.WriteLine("Adı          : " + musteri.MusteriAd);
        Console.WriteLine("Soyadı       : " + musteri.MusteriSoyad);
        Console.WriteLine("Tel No       : " + musteri.MusteriTelNo);
        Console.WriteLine("Adres        : " + musteri.MusteriAdres);
        Console.WriteLine("Cinsiyeti    : " + musteri.MusteriCinsiyet);
        Console.WriteLine("Açıklama     : " + musteri.MusteriAciklama + "\n");
      }      
    }

    public void MusteriSil(Musteri musteri)
    {
      musteriler.Remove(musteri);
      Console.WriteLine(musteri.MusteriTCNo + " " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " kaydı silindi \n");
    }
  }
}
