namespace _11_Ref_Out
{
    public delegate void FullNameDelegate(string name, string surname);
    class Program
    {

        public static void Main(string[] args)
        {
            //Ref ve Out keyword'leri ne işe yarar?
            //Out keyword : Bir metodda birden fazla değer dönmesi sağlanır. 
            //İlk değer return olarak dönülebilir. Bunun dışındaki 2 değeri out keyword üzerinden yapılabilir. 
            #region Ref
            //Ref: Value type değişken tiplerini reference type davranması sağlanabilir. 

            int a = 10;
            Console.WriteLine("a değişkeninin değeri=" + a);

            getData(ref a);

            Console.WriteLine("method çalıştıktan sonra__> a değişkeninin değeri=" + a); //getData içerisinde bir veri gönderdik a değişkeninin kopyası oluşur. 
                                                                                         //Stack bölgesinde ayrı ayrı a'nın kopyası oluşur. 




            #region Bir methodun dönüş tipi void olmasına rağmen return keyword'ü kullanılabilir mi ?
            //Return ifadesi kullanılabilir. Sadece bir data dönmek için kullanılmaz. Return; ile o methodun çalışması durdurulabilir.



            say();
            static void say()
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i > 10)
                    {
                        return;
                    }

                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        #endregion

        static void getData(ref int a)
        {
            a = a + 10; //a değişkeni kopya olarak cw'a kopya olarak gelmeyecek. Value gibi değil de datanın kendisi gelecek. Buradaki a yukarıdaki a olacaktır.
        }

        //stack                                             //heap
        //a=10                                                  //ref ile pointer'daki adres aynı oluyor . 
        //getData ile a yine 10

        #endregion

        #region Out


        //int cıkartmaa;
        //int carpp;
        //int topla = islem(2, 3, out carpp, out cıkartmaa);
        //Console.WriteLine(topla);
        //Console.WriteLine(carpp);
        //Console.WriteLine(cıkartmaa);


        //static int islem(int a, int b, out int carp, out int cıkartma) //Hem carpı hem de return değeri dönecek.
        //{
        //    carp = a * b;

        //    cıkartma = a - b;
        //    return a + b;
        //}
        #endregion



    }
}
