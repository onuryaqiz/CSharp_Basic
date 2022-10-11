using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_Extension_Examples
{
    public static class IntExtensions
    {
        public static double UsAl(this int sayi,int usSayisi)
        {
            return Math.Pow(sayi, usSayisi);
        }
    }
}
