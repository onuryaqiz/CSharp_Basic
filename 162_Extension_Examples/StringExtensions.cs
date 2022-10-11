using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_Extension_Examples
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpace(this string str)
        {
            // Yöntem 1;
            //// string sonuc =string.Empty;

            //foreach (var c in str)
            //{
            //    if (c!='')
            //    {
            //        sonuc += c;
            //    }
            //}
            //return sonuc;

            // Yöntem 2;
        
            return str.Replace(" " ,"");  
        }
    }
}
