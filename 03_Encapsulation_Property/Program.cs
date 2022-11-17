using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation_Property
{
    class Program
    {
        static void Main(string[] args)
        {
           PropertyTest pt = new PropertyTest();

            int test1 = pt.SadeceGetEdilebilirAlan;        // get işlemi gerçekleştirilebilir.
            //pt.SadeceGetEdilebilirAlan=30;               // set işlemi gerçekleştirilemez!
                                                           
            //int test2 = pt.SadeceSetEdilebilirAlan;      // get işlemi gerçekleştirilemez!
            pt.SadeceSetEdilebilirAlan = 10;               // set işlemi gerçekleştirilebilir.

            int test3 = pt.SetBloguPrivateAlan;            // get işlemi gerçekleştirilebilir.
            //pt.SetBloguPrivateAlan = 10;                 // set işlemi gerçekleştirilemez! 

            double test4 = pt.HesaplananAlan;              // get işlemi gerçekleştirilebilir.
            //pt.HesaplananAlan=10;                        // set işlemi gerçekleştirilemez! 
                                 

            Console.ReadKey();
        }
    }
}
