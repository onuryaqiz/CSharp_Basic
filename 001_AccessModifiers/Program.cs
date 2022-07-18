using System.Text;
using System.Threading.Tasks;

namespace _001_AccessModifiers
{
    class Program
    {

        static void Main(string[] args)
        {



        }

        public class A
        {
            protected string ProtectedVeri { get; set; } //Sadece,class ve miras aldığı class içerisinde erişilebilir.
            protected internal string protectedinternalveri { get; set; } //Protected : Miras alındığı zaman erişilebilirlik özelliği katıyor .
                                                                          //Internal:Sadece kendi assembly içerisinde nesne üzerinden erişilebilirlik özelliği katıyor .  

            private protected string privateprotectedveri { get; set; } //Sadece kendi assembly üzerinden erişilebiliyor. 
                                                                        //Nesne örneği alınsa bile erişilemiyor. 

            //public string publicveri { get; set; } //Üyeye her yerden erişilebilir. 

            //private string privateveri { get; set; } //Sadece ilgili class içerisinden erişilebilir.

            //internal string internalveri { get; set; }  //Assembly haricinde erişim sağlanamıyor .   

            /// <summary>
            /// ucgen:Miras alan class'a child deniyor.
            /// </summary>
            public class B : A //baseclass : Miras alınan class'a base class denir.
            {
                void hesapla()
                {
                    A s = new A();

                }
            }

        }
    }
}
