using System.Text;
using System.Threading.Tasks;

namespace _Virtual_Property
{
    class Program
    {
        //Virtual keyword'ü hangi yapılarda kullanılabilir ?
        //1-Event,2-Method, 3-Propety , 4-Index 

        //Virtual ile Abstract Method arasındaki fark nedir ?
        //Cevap : Virtual methodlar mutlaka gövdeye sahip olmak zorunda . Abstract methodun gövdesi yoktur . 

        //1-Abstract methodlar mutlaka override edilmek zorunda . 
        //2-Virtual methodlar , normal class'ta ve abstract class'ta tanımlanabilir. 
        //3-Bir üye abstract keyword kullanıyorsa , o class mutlaka abstract olmak zorunda . 




        static void Main(string[] args)
        {
            subClass s = new subClass();
            s.FirstName = "onur";
            s.LastName = "Yağız";
            Console.WriteLine(s.FullName);
        }
        public class baseClass
        {
            private string _firstName;
            private string _lastName;
            public string FirstName
            {


                get => _firstName;
                set => _firstName = value;
            }

            public string LastName
            {
                get => _lastName;
                set => _lastName = value;

            }

            public virtual string FullName
            {
                get => _firstName + " " + LastName;
            }
        }

        public class subClass : baseClass
        {
            //public override string FullName => base.FullName;

            public override string FullName => FirstName.ToUpper() + " " + LastName.ToUpper();
            //Methodları override edebildiğimiz gibi property'leri de override edebiliriz. 


        }

        //En önemli 2 delegate : 
        //1-public delegate bool Predicate<in T>(T obj); //Generic Delegate : 

        //2-public delegate TResult Func<in T,out TResult>(T arg); //Function delegate : İstediğimiz kadar generic T alıyor .
        //dönüş tipi hem de işaret edeceği kaç tane parametre varsa ifade edebiliyoruz.
        // public static void promosyon1(List<isci> isci , Func<isci,bool,string T2> promosyonDelegate) //function delegate 

    }
}
