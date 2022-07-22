namespace _002_Boxing_UnBoxing
{

    class Program
    {

        public static void Main(string[] args)
        {
            //Value Type'tan Reference Type'a dönüştürme işlemine boxing denir
            //Reference Type'tan Value Type'a çevirme işlemine de unboxing denir.

            int deger = 100; //value Type:byte,long,decimal,float , Stack'te tutulur. Implicity

            object deger2 = deger;//Boxing işlemi uygulandı. Reference Types:class,interface,delegate

            object deger3 = 100; // object bir Reference Type olduğu için explicity

            int deger4 = (int)deger3; //Unboxing işlemi uygulandı . 

            //Casting : Dönüştürme işlemidir. 

            long deger5 = 100; //Daha büyük veriyi daha küçük veri tipine dönüştürmeye çalıştığımız zaman hata verir.

            int deger6 = (int)deger5; //Cast işlemi
        }

    }
}