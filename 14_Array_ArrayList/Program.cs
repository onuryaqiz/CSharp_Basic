using System.Collections;
using System.Data.SqlClient;

namespace _14_Array_ArrayList
{
    public delegate void FullNameDelegate(string name, string surname);
    class Program
    {

        public static void Main(string[] args)
        {
            //Array ve ArrayList dizin yapısındadır. 

            //String[] array =new string[5] //Array'lerde nesne oluşturulduğu anda dizinin boyutunu belirtmek zorundayız.[5] gibi. Array'de tek bir veri tipi tutulabilir.

            //    ArrayList array_list = new ArrayList(); //Boyut belirtmek zorunda değiliz. New dediğimiz 4,8,16... şekilde memory'de yer arıyor. ArrayList'de Add methodu ile istediğimiz datayı geçebiliriz.

            //    a1.add(3);

            string[] isimler = new string[5]; //Array
            isimler[0] = "onur";

            int[] sayilar = new int[5];
            sayilar[3] = 30;


            ArrayList veriler = new ArrayList();
            veriler.Add("onur"); //Add methodu object aldığı için her veri tipini ekleyebiliriz. Object türünde veri tipi olduğu için memory'de çok yer kaplar .
                                 //Genelde List<string,int> yani Generic kullanılır.
            veriler.Add(22);
            veriler.Add(new SqlConnection());

            List<string> liste = new List<string>(); //Memmory'de daha az yer kaplar . Arraylist yerine . 
        }

    }
}