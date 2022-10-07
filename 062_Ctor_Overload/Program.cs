using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_Ctor_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // school nesnesi School class'ının parametre almayan ctor'u üzerinden üretildi !
            
            School school = new School();
            school.No = 302;
            school.Kapasite = 13;

            // school2 nesnesi 1 tane parametre alan ctor üzerinden üretildi!

            School school2 = new School(303);
            school2.Kapasite = 14;

            // school3 nesnesi 2 tane parametre alan ctor üzerinden üretildi!
            // No ve Kapasite bilgileri (301,10) nesne üretilirken parametre olarak ctor'a gönderildi!

            School school3 = new School(301,10);

            Console.ReadKey();
        }
    }
}
