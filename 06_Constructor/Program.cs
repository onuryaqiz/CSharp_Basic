namespace _06_Constructor
{

    class Program
    {

        static void Main(string[] args)
        {
            Book book = new Book(); // Yeni bir nesne üretildiği için bu satırda Book sınıfına ait ctor metodu çalışır!

            book.Id = 2;
            book.Ad = "Satranç";
            book.Yazar = "Stefan Zweig";
            book.Test(); // Test methodu çalıştı .
            book.Test(); // Test methodu tekrar çalıştı. Ctor ise bir nesne için sadece bir kez çalışabilir.Üst satırdaki nesnenin üretilmesi sırasında 
            // book nesnesi için aşağıda "new Book()" şeklinde kullanım , nesnenin yeniden üretilmesini sağlar.Yukarıda girilen bilgilerin hepsi sıfırlanarak yeni bir nesne oluşur.
            // Nesne yeniden oluşturulduğu için ctor yeniden çalışacaktır.
            book = new Book();

            Book newBook = new Book(); //  newBook adında yeni bir nesne üretildi. Book sınıfındaki ctor çalışır!
            newBook.Id = 3;
            newBook.Ad = "Suç ve Ceza";
            newBook.Yazar = "Dostoyevski";
            newBook.Test();

            // Book sınıfının ctor'u çalıştı.
            new Book();

            // Book sınıfının ctor'u döngü içerisinde 10 kez çağrıldı.
            for (int i = 0; i < 10; i++)

                new Book();

            // nesnelerin üretilmesi aşamasında bazı işlemler gerçekleştirmek istenirse ctor yazılabilir.Değişkenlere default değerlerin atanması , istatistik bilgilerinin çıkartılması vb.

            Console.ReadKey();



            //    //Constructor ?
            //    //Bir class'ın özel bir method tipi olup nesne oluştuğu zaman yani bir class'tan new keyword'ünü kullanarak , otomatik bir şekilde çalışan metodlardır. 
            //    //Constructor isimleri , class isimleri ile aynı olmak zorunda.
            //    //Herhangi bir veri dönmezler.
            //    //Erişim belirleyici olarak , ya public ya da private olarak tanımlanabilir. 
            //    //Constructor'lardan herhangi bir şekilde herhangi bir hatayı fırlatabiliriz.

            //    mainClass c = new mainClass();
            //    denemeClass c2 = new denemeClass(); //Parantez açıp kapatılabildiğine göre default constructor .
            //    Console.WriteLine(c2.deneme2);


            //    //Kaç çeşit constructor vardır ?

            //    //1-Default Constructor : 2'ye ayrılır.
            //    //  a-System Defined:Eğer bir programcı olarak , herhangi bir class içerisine constructor yazılmadığında system tarafından default olarak yazılıyor.
            //    //  b-User Defined : Programcı tarafından yazılanlara da user defined denir. 
            //    //2-Parameterized Constructor
            //    //3-Copy Constructor
            //    denemeClass1 d = new denemeClass1("onur", false);
            //    denemeClass1 d2 = new denemeClass1(d); //Aynı değerlerden yeni bir nesne örneği oluşmuş oldu. Yani yukarıdaki kodu tekrar tekrar yazmak
            //                                           //yerine "d" ile copy constructor yardımıyla kolayca nesne oluşturulabildi.
            //                                           //4-Static Constructor
            //    copyConstructor copy = new copyConstructor();
            //    copyConstructor copy2 = new copyConstructor();
            //    copyConstructor copy3 = new copyConstructor();

            //    //5-Private Constructor

            //    //baseClass,childClass örneği
            //    subClass s = new subClass("onur", "yağız", 12);
            //    Console.WriteLine(s.Name);



            //}

            //class ornekClass //default constructor
            //{
            //    public int deger; //default 0
            //    public bool deger2; //default false

            //    public ornekClass() //user defined 
            //    {
            //        deger = 100; //Burada degeri biz verdiğimiz için system olanı consolda getirmedi!
            //        deger2 = true;//Burada degeri biz verdiğimiz için system olanı consolda getirmedi!
            //    }
            //}
            //class mainClass
            //{
            //    public mainClass()
            //    {
            //        Console.WriteLine("bu method otomatik bir şekilde çağrıldı.");
            //    }
            //}

            ////PARAMETERIZED CONSTRUCTOR : Herhangi bir constructor'a parametre verilirse parameterized constructor denir.
            ////Soru : Neden parametre alan constructor tanımlarız. 
            ////Cevap : Genelde class içerisindeki üyelere ilk değerleri vermek için kullanırız. Nesne örneği oluşturulurken değeri verebiliriz.
            //internal class denemeClass
            //{
            //    public string deneme;
            //    public bool deneme2;

            //    public denemeClass() //Bunun olmasının sebebi yukarıda bunu çağırmak istediğimizde hata vermesi . Default olarak da boş ctor oluşturduk . Hatanın gitmesi için .
            //    {

            //    }
            //    public denemeClass(string deneme, bool deneme2)
            //    {
            //        this.deneme = deneme; //this keyword'ü denemeClass içindeki denemeyi , =deneme ise parametreyi ifade eder.
            //        this.deneme2 = deneme2; //Parametre ile property aynı isimde olduğu için this keyword'ünü kullandık. 

            //    }

            //}

            ////COPY CONSTRUCTOR: Eğer bir constructor parametre olarak class'ın kendisini parametre alırsa ,
            ////daha önce varolan instance'ın değerlerinden yeni bir instance oluşturmak.
            //internal class denemeClass1
            //{

            //    public string isim { get; set; }
            //    public bool isim2 { get; set; }

            //    public denemeClass1(string isim, bool isim2)
            //    {
            //        this.isim = isim;
            //        this.isim2 = isim2;
            //    }
            //    public denemeClass1(denemeClass1 denemeClass1)
            //    {
            //        this.isim = denemeClass1.isim;
            //        this.isim2 = denemeClass1.isim2;
            //    }
            //}

            ////STATIC CONSTRUCTOR NEDİR?
            ////Static keyword kullanılarak oluşturulan constructor'lara verilen isimdir. 
            ////Static constructor'lar o class'tan bir nesne oluştuğu anda 1 kere çalışır . Daha sonra çalışmaz . Her nesne örneğinde çalışmaz . İlk nesne örneğinde çalışır.
            ////Static değerleri ilk değerlerini vermek için kullanırız. Bir class içerisinde 1 kere çalışmasını istediğimiz bir yapı varsa kullanırız.
            ////Static constructor'lar her zaman , normal const'lardan önce çalışır. 
            //public class copyConstructor
            //{

            //    public string copyIsim { get; set; }

            //    public int copyYas2 { get; set; }

            //    public static string Copysoyisim { get; set; }

            //    static copyConstructor() //Static constructor'lar herhangi bir erişim belirleyicisine sahip olmazlar.
            //    {
            //        Copysoyisim = "Yağız";
            //        Console.WriteLine("Static Constructor çalıştı...");
            //    }
            //    public copyConstructor()
            //    {
            //        Console.WriteLine("normal constructor çalıştı...");
            //    }
            //}
            ////PRIVATE CONSTRUCTOR NEDİR ?
            ////Erişim belirleyici(Access Modifiers) olarak private kullanılıyor . 
            ////Kullanım amacı , eğer bir class'ın o class dışından nesne örneği alınmasını istemiyorsak , private olarak tanımlarız. Class içerisinde, nesne örneği alınabilir. 

            //internal class privateConstructor
            //{
            //    public int MyProperty { get; set; }
            //    public int MyProperty2 { get; set; }
            //    private privateConstructor()
            //    {

            //    }
            //    public privateConstructor getInstance()
            //    {
            //        return new privateConstructor();
            //    }
            //}
            ////Soru:Bir child-class, parent-class'ın constructor'larını çağırabilir mi ?
            ////Child class'lardan üst class'ların const'larını çağırabiliriz.
            ////Soru:Bir class new() ile nesne örneği alınmaktan nasıl koruruz ?
            ////Cevap:Eğer bir class içerisinde private constructor kullanırsak , new ile nesne örneği alınmasını koruruz. 

            //internal class baseClass
            //{
            //    public string Name { get; set; }
            //    public int Age { get; set; }

            //    public baseClass() //aşağıda parametre alan bir constructor tanımlandığı için boş bir constructor oluşturuldu .
            //    {

            //    }
            //    public baseClass(string name, int age)
            //    {
            //        Console.WriteLine("base constructor çalıştı");
            //        this.Name = name;
            //        this.Age = age;
            //    }
            //}

            //internal class subClass : baseClass
            //{
            //    public subClass() //aşağıda parametre alan bir constructor tanımlandığı için boş bir constructor oluşturuldu .
            //    {

            //    }
            //    public string Surname { get; set; }

            //    public subClass(string name, string surname, int age) : base(name, age) //base : ile üst sınıfın constructorlarını çalıştırabiliriz.
            //    {
            //        //age ve name baseClass'tan geliyor. İlk olarak baseClass'taki const çalışır . Sonra child'taki const çalışır.
            //        Console.WriteLine("subclass constructor çalıştı.");
            //        this.Surname = surname;

            //    }
            //}
            ////Soru:Static constructor'lar herhangi bir parametre alabilir mi ?
            ////Cevap : Static keyword ile declare edilen const parametre alamaz. 

        }

    }
}