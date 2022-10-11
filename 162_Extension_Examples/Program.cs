using _162_Extension_Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            // int tipi için UsAl işlemi yapacak extension methodu
            int sayi = 5;
            Console.WriteLine(sayi.UsAl(3));
            #endregion

            #region Örnek 2
            //String tipi için boşluk karakterlerini temizleme işlemi yapan extension methodu 
            string cumle = "   test   - deneme  -  son  ";
            Console.WriteLine(cumle.RemoveWhiteSpace());
            #endregion

            Console.ReadKey();
        }
    }
}
