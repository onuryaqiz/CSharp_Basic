namespace _15_Params
{
    public delegate void FullNameDelegate(string name, string surname);
    class Program
    {

        public static void Main(string[] args)
        {
            //Params keyword'ünün amacı nedir ? nasıl kullanılır ?
            //Eğer bir methodun sınırsız sayıda argument alınması isteniyorsa params keyword kullanılıyor . 

            // Console.WriteLine(topla(new int[] { 1, 2, 3, 4, 5 })); params olmadan

            Console.WriteLine(topla(1, 2, 3, 4, 5, 6, 7, 8, 9));
            //Parametre ile Argument arasındaki fark : Method içindeki değerler argument'tır.
        }

        public static int topla(params int[] sayilar)
        {
            int sum = 0;
            foreach (var item in sayilar)
            {
                sum += item;
            }
            return sum;
        }


        //public static int topla(int[] sayilar)
        //{
        //    int sum = 0;
        //    foreach (var item in sayilar)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
    }
}