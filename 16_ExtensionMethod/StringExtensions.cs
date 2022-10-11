using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ExtensionMethod
{
    public static class StringExtensions
    {

        public static string RemoveNumeric(this string str)
        {
            // str:"deneme123Test456"
            // return :"denemeTest"

            string sonuc = string.Empty;

            foreach (var c in str)
            {
                if (!Char.IsNumber(c))
                {
                    sonuc += c;     
                }

            }

            return sonuc;
        }
    }
}
