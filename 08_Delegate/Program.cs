namespace _08_Delegate
{
    public delegate void FullNameDelegate(string name, string surname);
    class Program
    {

        public static void Main(string[] args)
        {
            //Delegate Nedir?
            //NetFramework'ün 2 yapısı vardır . 1-Delegate 2-Event
            //Delegate'ler bir methoda referans veren yapılardır. 
            //Arayıcılık yapan methodlar da denilebilir. Dynamic olarak kontrol edebilmemizi sağlar.
            //Bir class içerisinde bir methoda 2 ihtimalle çağırabiliriz. Eğer class içerisindeki method static bir method değilse , nesne örneği alarak çağırabiliyorduk.
            //Örnek tanımlama : public delegate void HelloDelagate(string Message); 

            //Delegate(temsilci)'ler kaç şekilde sınıfılandırılır?
            //1-SingleCast Delegate : Eğer oluşturmuş olduğun delagate sadece bir methoda referans veriyorsa , singleCast Delegate denir. 
            //2-MultiCast Delegate : Eğer oluşturmuş olduğun delagate sadece birden fazla methoda referans veriyorsa , multiCast Delegate denir.

            FullNameDelegate fullNameDelegate1 = new FullNameDelegate(FullNameMethod1); //Delegate üzerinden methodu çalıştırabiliriz. singleCast Delegate

            FullNameDelegate fullNameDelegate2 = new FullNameDelegate(FullNameMethod2);

            FullNameDelegate fullNameDelegate3 = new FullNameDelegate(FullNameMethod3);


            //fullNameDelegate1("onur", "yağız"); //singleCast

            FullNameDelegate zincirDelegate = fullNameDelegate1 + fullNameDelegate2 + fullNameDelegate3; //multiCast Delagate

            zincirDelegate("onur", "yağız");
        }

        public static void FullNameMethod1(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }

        public static void FullNameMethod2(string name, string surname)
        {
            Console.WriteLine(name.ToUpper() + " " + surname.ToUpper());
        }

        public static void FullNameMethod3(string name, string surname)
        {
            Console.WriteLine(surname.ToUpper() + " " + name.ToUpper());
        }
    }
}