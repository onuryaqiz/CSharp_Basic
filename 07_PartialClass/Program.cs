using _07_PartialClass;

namespace _07_Partial
{

    class Program
    {

        static void Main(string[] args)
        {
            //Partial Class Nedir?
            //Bir class nesnesinin 2 veya daha fazla parçaya bölünmesi denir.
            //Bir class var ve içerisinde 100'lerce property var . Yine aynı class'ın içerisinde 70-80 method var. Kod karmaşıklığını azaltmak için ,
            //devreye partial class'lar giriyor. Partial keyword kullanılarak , aynı class ismi üzerinde , bir class'ta methodlar , diğer class'ta property'ler 
            //tutulur . İsmi de aynı olur. Bir class üzerinde birden fazla programcı kodlama imkanı sağlar. Bir 2 farklı class compile yani derleme esnasında ,
            //tek bir class olarak tek bir class olarak bir araya getirilir.
            //Aynı zamanda entity framework kullanıldığında , codefirst log esnasında oluşan tüm class'lar partial class'lardır. 

           
            Product product = new Product();
                

        }
    }
    //Soru:Partial class'ların farklı bölümleri farklı interface'ler implement edilebilir mi ?
    //Cevap : Implement edebilir. 

    public interface birinci
    {
        void birincimethod();

        int birinciProperty { get; set; }
    }

    public interface ikinci
    {
        void ikincimethod();

        int ikinciProperty { get; set; }
    }

    public interface ucuncu
    {
        void ucuncumethod();

        
    }

    //Partial Struct , interface ,method oluşturmak mümkün mü ?
    //Cevap : Bölebiliriz. Compile zamanında biraraya gelirler.


    //Partial Methodlar nasıl oluşturulur ?
    //Methodları da partial ile bölebiliriz. 2 partial class var . Ayrı partial class içerisinde partial method olacaksa , imzası(isim,parametre tipi ,sayısı) ve gövdesi olur.
    //partial method'lar void olmak zorunda . Override edilemezler.
    partial class Deneme
    {
        partial void ornek(string value1); //Methodun imzası ; methodun ismi , aldığı parametre sayısı ve tipi imzasını oluşturur. Dönüş tipi imzasını oluşturmaz.
        Deneme deneme = new Deneme(); //Class içinden methoda erişim sağlanabildi.
        
    }

    partial class Deneme
    {
        partial void ornek(string value1)
        {
            Console.WriteLine(value1);
        }
    }
   // Deneme deneme = new Deneme(); //Partial methodlar private özelliğe sahip olduğu için sadece kendi içlerinde kullanılabilirler. Partial methoda access modifiers veremezsin . Default olarak private'tır.

}