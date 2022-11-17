using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapsulation
{
    public class Order
    {
        // Id ve price field'ları private olduğu için nesne kullanıcı bu field'lara direkt erişim sağlayamaz. Erişim sağlamak için aşağıda tanımlanan public durumdaki kapsül methodlar kullanılmak zorundadır.
        // Kapsül methodların görevi private field'lara yapılan erişimleri kontrol altına alarak değerlerin kontrollü şekilde okunmasını ve yazılmasını sağlamaktır. 
        
        private int id;
        private int price;
    
        // get_price methodunun amacı sadece private bir field olan price'ın sakladığı değeri okumak(nesne kullanıcına iletmek)dir.

        public int get_price()
        {
            return price;
        }

        // set_price methodunun amacı nesne kullanıcısının private durumdaki field'ına kontrollü bir şekilde değer atanmasını sağlamaktır. Bu örnekte uyguladığımız validasyon ile price değerinin 0 girilmesini garanti altına almış olduk. Böylelikle 0 tutarlı bir sipariş oluşturulmayacak . 
        public void set_price(int newPrice)
        {
            if (newPrice == 0)
                throw new ArgumentException("Geçersiz bir fiyat girdiniz ! Fiyat sıfırdan büyük olmalıdır!");
            else if (newPrice == price)
                throw new ArgumentException("Daha önceden tanımlı olan fiyat ile aynı değeri girdiniz! Lütfen farklı bir değer giriniz!");
            else if(newPrice>0)
                price = newPrice;

        }

        public int get_id()
        {
            return id;
        }

        public void set_id(int newId)
        {
            if (newId > 0 && newId < 1000)
                id = newId;
            else
                throw new ArgumentException("Id değeri 0-1000 arasında olmalıdır!");
        }

    }
}
