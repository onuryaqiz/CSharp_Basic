using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation_Property
{
    // Private field'ların kapsüllenmesi için gereken get ve set methodlarının kolay bir şekilde oluşturulmasını sağlayan üyelere property denir.
     class Order
    {
        // .Net'de bir class tasarlanırken genelde field'lar private olarak oluşturulur ve her private field'a karşılık olarak o field'ın kapsülü olacak bir property yazılır.
        int id;
        int price;

        // Proje derlendiğinde aşağıdaki property'lerin get ve set methodları arka planda otomatik olarak oluşur.

        public int Id
        {
            get { return id; }
            set
            {
                if(value>0 && value < 1000)
                    id = value;
                else
                    throw new ArgumentException("Id değeri 0-1000 arasında olmalıdır!");
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Geçersiz bir fiyat girdiniz! Fiyat sıfırdan büyük olmalıdır !");
                else if (value == price)
                    throw new ArgumentException("Daha önceden tanımlı olan bir fiyat ile aynı değeri girdiniz! Lütfen farklı bir değer giriniz!");
                else if(value>0)
                    price = value;
            }
        }

    }
}
