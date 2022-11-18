using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            // Bir tane Personel class'ı oluşturalım , içerisinde Id,AdSoyad,Yas, Maas, Unvan, Adres property'leri encapsulation'a uygun şekilde oluşturulsun . Adres dışındaki hiçbir alan boş bırakılmasın, Yas değeri 0'dan küçük 100'den büyük olamasın. Id ve Maaş ise 0'dan küçük olamasın.

            Personel personel = new Personel();

            try
            {
                personel.Id = 10;
                personel.AdSoyad = "Onur Yağız";
                personel.Maas = 4000;
                personel.Yas = 28;
                personel.Unvan = "Yazılımcı";
                personel.Adres = "Kadıköy";

                Console.WriteLine("Çalışan Adı:{0},Maaşı: {1}",personel.AdSoyad,personel.Maas);
            }
            catch (Exception ex)
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Hata oluştu! Hata Detayı:{0}",ex.Message);
            }
            #endregion

            #region Örnek 2 
            //Bir tane Urun sınıfı oluşturalım, içerisinde Id, UrunAdi, Fiyat, KdvDahilFiyat alanları olsun. Encapsülation'a en uygun şekilde tasarlayalım.
            //Id ve fiyat 0'dan küçük olamasın
            //UrunAdi boş geçilemesin, 3 karakterden kısa, 100 karakterden uzun olamasın
            //KdvDahilFiyat fiyat değerinin üzerine %18 ekleyerek Kdv'li fiyatı hesaplasın.
            // TODO:

            #endregion

            #region Örnek 3 
            //SiviTuru adında bir class yazalım, içerisinde Id, Tur, KaynamaSicakligi ve SuankiSicaklik adlarında property'leri encapsülation'a uygun şekilde tasarlayalım. 
            //SuankiSicaklik değeri KaynamaSicakligi değerinin üzerine çıkamasın! Çıkması durumunda SıvıTuru bilgisi verilerek Buharlastı hata mesajı fırlatılsın.


            #endregion
        }
    }
}
