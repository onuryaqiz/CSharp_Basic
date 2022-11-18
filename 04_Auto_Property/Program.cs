using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Auto_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();

            urun.Id = 10;
            urun.UrunAdi = "Laptop";
            urun.Fiyat = 6000;
            urun.Kdv = 0.18;
            // urun.SadeceGet=10; // Sadece get işlemi uygulanabilir, set uygulanamaz!

            Console.WriteLine("Id:{0}\nAdi: {1}\nFiyat: {2}\nKdv : {3}\nSadeceGet: {4}",urun.Id,urun.UrunAdi,urun.Fiyat,urun.Kdv,urun.SadeceGet);

            Console.ReadKey();
        }
    }
}
