namespace _02_AbstactStatic
{
    public class Class1
    {

        static void Main(string[] args)
        {
            //Bir class abstract olarak ne zaman declare edilmelidir?
            //Cevap:Eğer bir class'ın üyeleri,field'ları,property,methodları , abstract keyword'üne sahip ise o class abstract olarak belirtilmelidir.

            //Soru:Abstract method nedir ?
            //Abstract class içerisinde bir abstract keyword uygularsak o method abstract method olur.

            //Abstract method'lar ne zaman kullanılır ?
            //Cevap : Soyut methodlar , eğer bir methodun alt sınıflarda yani miras edilmiş sınıflarda override edilmesini istiyorsanız ve gövdesinin yazılmasını istiyorsak ,
            //methodu abstract olarak belirtmeliyiz . 

        }
        //Soyut sınıflar static olarak işaretlenemez. Soyut sınıflar static üyelere , metodlara sahip olabilir.
        //Soyut sınıflar constructor'lara sahip olabilir. Kullanım amacı ; Soyut sınıftaki üyeleri değişkenleri ilk değer vermek için kullanılabilir. 
        //Constructor parametre alma ile almama arasında fark vardır . 

        internal abstract class basekisi
        {
            public abstract void calis();
            public string isim { get; set; }

            public string soyisim { get; set; }

            public abstract void yaz();
            public basekisi(string name, string surname)
            {
                Console.WriteLine("soyut sınıf consructor çalıştı");
                isim = name;
                soyisim = surname;
            }
            public class isci : basekisi
            {
                public override void yaz()
                {
                    Console.WriteLine("işçi sınıfındaki yaz metodu çalıştı");

                }
                public override void calis()
                {
                    Console.WriteLine("işçi sınıfı çalıştı");
                }
                public isci()
                {
                    Console.WriteLine("işçi sınıfının contructor çalıştı");
                }
            }
        }


    }
}