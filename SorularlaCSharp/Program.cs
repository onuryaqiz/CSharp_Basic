using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    class Program
    {

        static void Main(string[] args)
        {

            //Asbtract class içerisinde ne tür yapılar tanımlanabilir ?
            // - Static ve static olmayan field , property , indexer , metodlar tanımlanabilir. Herhangi bir class'ta yapılan bir çok şeyi abstract class içerisinde tanımlanabilir.


        }
        abstract class basekisi
        {
            public string İsim { get; set; }
            public string soyisim { get; set; }

            public void yaz()
            {
                global::System.Console.WriteLine(İsim + " " + soyisim);
            }
        }


        class isci : basekisi
        {

            public string hdf { get; set; }



        }
        class yonetici : basekisi
        {

            public string tip { get; set; }
        }
        class editor : basekisi
        {

            public string abc { get; set; }

        }

    }
}