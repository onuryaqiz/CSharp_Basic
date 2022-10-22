using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_NonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun(10, "Klavye", 100);
            Console.WriteLine(urun.Info());

            // Aşağıdaki üyeler non-static olduğu için urun nesnesi üzerinden erişilebilirler.
            urun.Id = 10;
            urun.Name = "Klavye";
            urun.Price = 100;
            urun.Info();

            // Urun class'ının içindeki üyeler non-static olduğu için aşağıdaki gibi Urun class'ı üzerinden erişilemez!
            //Urun.Id = 10;
            //Urun.Name = "Test";
            //Urun.Price = 1000;
            //Urun.Info();

            urun.ZamYap(0.10); // 0.10 yerine .10 yazabiliriz ikisi de aynı anlama gelir.

            Console.WriteLine(urun.Info(urun));

            Console.ReadKey();

        }
    }
}
