using System.Data.SqlClient;

namespace _12_Using
{
    public delegate void FullNameDelegate(string name, string surname);
    class Program
    {

        public static void Main(string[] args)
        {
            //Using ifadesi ne için kullanılır ?
            //Büyük çaplı projelerde bellek yönetimi önemlidir. Değişkenlerin ve nesnelerin bellekten ne zaman silineceğine karar veren yapı .NET'de Garbage Collector'dır.
            //Arkasında kullandığı algoritma sayesinde nesnenin kullanılmadığını anladığında siler. 
            //Bellek yönetimini daha iyi kullanabilmek için , nesnenin GC'ye gitmeden using ile nesneyi silebiliriz.

            SqlConnection con2 = new SqlConnection();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally //try veya catch düzgün çalışırsa ya da çalışmazsa da finally mutlaka çalışır.
            {
                con2.Dispose();
            }


            using (SqlConnection con = new SqlConnection()) //Örnek kod
            {

            } //Burada kod bittikten sonra using ifadesi direkt olrak con nesnesini bellekten silecektir. Using ifadesi içerisinde kullanılacak ifadeler mutlaka ,
              ////IDisposable implement edilmek zorundadır.
            ///
            //using (StreamReader sr=new StreamReader()) //Burada da IDisposable implemente edilmiştir. F12 ile içine girince görülebilir.
            //{

            //}

        }
    }
}
