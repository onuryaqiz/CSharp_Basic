using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation_Example
{
    class Personel
    {
        int id;
        string adSoyad;
        int yas;
        int maas;
        string unvan;

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Id değeri 0'dan küçük olamaz!");
                else
                    id = value;
            }
        }
        public string AdSoyad
        {
            get { return adSoyad; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("AdSoyad değeri boş bırakılamaz!");
                else
                    adSoyad = value;
            }
        }
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value <= 0 || value > 100)
                    throw new ArgumentException("Yas değeri 0'dan küçük 100'den büyük olamaz!");
                else
                    yas = value;
            }
        }
        
        public int Maas
        {
            get { return maas; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Maas değeri 0'dan küçük olamaz!");
                else
                    maas = value;
            }
        }
        public string Unvan
        {
            get { return unvan; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Unvan değeri boş olamaz!");
                else
                    unvan=value;

            }
        }
        public string Adres { get; set; }
    }
}
