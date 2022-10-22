using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegate
{
    // Temel .Net tiplerinden biridir , referans türlüdür.
    // Methodların çalıştıkları bellek alanlarının başlangıç adreslerini saklayabilirler.Diğer bir deyişle methodları adreslerini saklama tekniğiyle işaret edebilirler.
    // Birden fazla method adresi bir delege nesnesine bağlanabilir.
    // Yoğun olarak kullanım noktaları ; 
    //   Event bazlı programlama
    //   LINQ
    //   Asenkron programlama 
    //   Bir delege tanımlanırken , adreslerini saklayabileceği method imzasıyla birlikte tanımlanır.

    // Delege'nin 2 amacı ; 
    // 1- Method adreslerini daha sonra kullanmak üzere saklamak (Event'lar bu mantıkla oluşur.)
    // Bir methoda parametre olarak başka bir methodu adresiyle geçmek (LINQ ve Entity Framework'de yoğun şekilde kullanılır.)

    //( Temsilci adında bir tip tanımlandı. Bu tipin nesneleri, çalışma zamanında geriye bir şey dönmeyen ve parametre almayan tüm methodları işaret edebilir.
    delegate void Temsilci();

    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 methodu çağrıldı.");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 methodu çağrıldı.");
        }

        static void Main(string[] args)
        {
            // Method1 methodu çağrılmadı ! Dolayısıyla bu bir method çağrısı olmadığından dolayı , parantez açıp kapatılmaz !
            // Temsilci t= new Temsilci(Method1);
            Temsilci t = Method1; // yukarıdaki bu yazım birebir aynıdır.

            // Delegate'e yeni bir method daha ekledik.
            t += Method2;

            // Aynı methodu 2.kez ekleyebiliriz.
            t += Method2;

            //t'nin işaret ettiği method listesindeki (delege nesnesi ) tüm methodlar bağlanma sırasıyla çağrılır.
            t.Invoke();

            Console.ReadKey();

        }
    }
}