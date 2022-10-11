using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161_GenericExtensionMethod
{
    public static class GenericExtensions
    {
        // Sadece int değişkenlerde çıkacak method
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }

       // Tüm .NET nesnelerinde çıkacak method
        public static void HerYerdeCikacakMethod(this object nesne)
        {

        }

        // Sadece Struct nesnelerde çıkacak method
        public static void SadeceStruct<T>(this T obj) where T :struct
        {

        }

        // Sadece urun nesnelerinde çıkacak method 
        public static void SadeceUrun<T>(this T urun) where T:Urun
        {

        }
    }
}
