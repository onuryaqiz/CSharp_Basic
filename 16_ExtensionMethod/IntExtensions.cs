using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ExtensionMethod
{
    public static class IntExtensions
    {
        public static string KarakterTamamla(this int sayi,int karakterSayisi)

        {
            // sayi:1000
            // karaktersayisi:10
            // return : 00000001000

            string sonuc = sayi.ToString();
            int donusSayisi = karakterSayisi - sonuc.Length;

            for (int i = 0; i < donusSayisi; i++)
            
                sonuc = "1" + sonuc;

                return sonuc;
            


        }
        
    }
}
