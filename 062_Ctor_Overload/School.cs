using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_Ctor_Overload
{

    class School
    {
        public int No { get; set; }
        public int Kapasite { get; set; }


        public School()
        {
            Console.WriteLine("Parametre almayan ctor çalıştı...");
        }

        // Ctor'da bir method olduğu için methodlarda yapılan aşırı yükleme(overload) yöntemi kullanılarak birden fazla ctor versiyonu yazılabilir!

        public School(int no)

        {
            No = no;
            Console.WriteLine("Bir parametre alan ctor çalıştı...");
        }

        public School(int no , int kapasite)

        {
            No = no;
            Kapasite = kapasite;
            Console.WriteLine("İki parametre alan ctor çalıştı...");
        }
    }
}

