using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order();

            // Aşağıda Id ve Price property'leri için yeni bir değer ataması yapıyoruz . Property'lerin değer atamaları field'larda olduğu gibi eşittir'in(=) sağ tarafına yazılarak yapılır.
            order.Id = 10;
            order.Price = 500;

            // Id ve fiyat değerleri çekiliyor(get ediliyor..)
            Console.WriteLine("Id: {0} Price {1} ", order.Id,order.Price);

            Console.ReadKey();

        }
    }
}
