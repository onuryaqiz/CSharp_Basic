namespace _03_Abstract_Interface
{
    public class Class1
    {
        class Program
        {

            static void Main(string[] args)
            {
                //Interface: Field'lara sahip olmaz . Methodlara ve property'lere sahip olur .
                //Ama Abstract sınıflar; Field'lara , methoda ve property'e sahip olabilir. 

                //Bir Interface birden fazla Interface'i miras alabilir. 
                //Abstract sınıflar tek bir class'tan miras alamaz. 

                //Interface'lerde erişim belirleyiciler yoktur. 
                //Abstract class'larda erişim belirleyiciler vardır. 

                //Interface'lerde method gövdeleri olmaz. 
                //Abstract class'larda method gövdesi olur . Method gövdesi olmayan methodlarda tanımlamak için , soyut(abstract) sınıflarda abstract keyword'ü kullanan methodlar tanımlayabiliyoruz.
            }
            interface Ikisi : IComparable, IDisposable //Birden fazla Interface implemente alabildi.
            {
                // string veri; //field tanımlanamaz.
                string veri { get; set; }

                void yaz(string isim); //Methodun imzası ;dönüş tipi, aldığı parametre , ismi 
            }

            internal abstract class a
            {

            }
            internal abstract class b
            {

            }
            abstract class kisi : a
            {
                void yaz(string isim)
                {
                    Console.WriteLine(isim);
                }
                public abstract void yaz2();

                string veri; //field tanımlanabildi. 
            }
        }

    }
}

