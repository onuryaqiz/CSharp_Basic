using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            // 1000'den büyük id'li bir sipariş nesnesi oluşturulamaz ! Aşağıdaki satır çalışma zamanında hata verir.
            // order.set_id(1500);

            order.set_id(500);

            // id değerini çekiyoruz(get işlemi) En son 500 değeri atandığı için ekrana 500 yazar.
            Console.WriteLine(order.get_id());

            try
            {
                // ilk değer belirlendi
                order.set_price(200);
                Console.WriteLine("Fiyat giriniz: ");
                int newPrice = Convert.ToInt32(Console.ReadLine());

                order.set_price(newPrice);
                Console.WriteLine("Güncel fiyat: {0}",order.get_price());
            }
            catch (ArgumentException ex)
            {

                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
           Console.ReadKey();
        }
    }
}
