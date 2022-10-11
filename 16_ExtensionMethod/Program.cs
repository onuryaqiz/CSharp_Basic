using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension methodları yardımcı(helper) methodlar olarak düşünebiliriz.
            // Extension method, static bir tipe yazılmış methodu , sanki nonstatic üyeymiş gibi çağırma imkanı verir.[TiptenUretilenDegiskenAdi.MethodAdi] notasyonu ile erişilmesine olanak sağlar.
            // Extension methodu kullanmak için yapılması gereken şey, static class içindeki static methodun ilk parametresinin başına "this" keyword'ünü eklemektir.



            #region IntExtensions

            int sayi = 1;
            // Normal static class ve static kullanımı
            Console.WriteLine(IntExtensions.KarakterTamamla(sayi, 5));
            #endregion



            #region StringExtensions
            // Normal static kullanımı
            string karisikKelime = "deneme124Test456";
            Console.WriteLine(StringExtensions.RemoveNumeric(karisikKelime));

            // Extension Kullanımı
            Console.WriteLine(karisikKelime.RemoveNumeric());

            #endregion


            Console.ReadKey();
        }
    }
}
