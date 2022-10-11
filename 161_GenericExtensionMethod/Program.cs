using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161_GenericExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            sayi.KareAl();
            sayi.HerYerdeCikacakMethod();
            sayi.SadeceStruct<int>(); // Generic tipi belirtmesek de olur .
    
            StructTest st=new StructTest();

            st.HerYerdeCikacakMethod();
            st.SadeceStruct();

            Urun urun = new Urun();
            urun.HerYerdeCikacakMethod();
            urun.SadeceUrun();

            Console.ReadKey();        
        
        }
    }


    public class Urun
    {
    }

    struct StructTest
    {


    }
}
