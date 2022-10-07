using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ctor_MandatoryParameter
{
    class Student
    {
        public string AdSoyad { get; set; }
        public string Sinif { get; set; }
        public string Telefon { get; set; }
        public string DogumYeri { get; set; }
        public int Yas { get; set; }

       // ctor parametre alabilir , parametre alan bir ctor yazıldığı taktirde nesne üretilirken bu parametrelerin gönderilmesi zorunlu hale gelir.
       // Bir class'dan nesne üretilirken zorunlu olmasını istediğimiz bazı değerlerin girildiğini garanti altına almak için bu yöntem kullanılabilir.
       // Aşağıdaki ctor ile AdSoyad,Sinif ve Telefon değerlerinin nesne üretilirken girilmesi garanti altına alınmıştır!

        public Student(string adSoyad , string sinif, string telefon)
        {
            // Parametre olarak gelen değerleri nesnenin ilgili propety'lerine aktarıyoruz.
            AdSoyad = adSoyad;
            Sinif = sinif;
            Telefon = telefon;
        }

        // Bir class'tan nesne üretilmesini engellemek için ctor'un erişim belirleyicisi private olarak belirlenebilir.
        // ctor private yapıldığı taktirde yalnızca tanımlandığı tip tarafından örneklenebilir!
        //private Student()
        //{

        //}
    }
}
