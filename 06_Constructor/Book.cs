using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Constructor
{
    class Book
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }

        public void Test()
        {
            Console.WriteLine("Test methodu çalıştı...");
        }

        //Ctor (Yapıcı oluşturucu method) normal methodlardan farklı özel bir methoddur.
        //Ctor methodunun adı, içinde bulunduğu tipin adı (class adı) ile aynı olmak zorundadır
        //Ctor methodlarının geri dönüş tipi yoktur! Otomatik olarak void olurlar
        //Ctor methodu diğer methodlarda olduğu gibi nesne kullanıcısının istediği anda direkt olarak çağrılamaz
        //Ctor methodu nesnenin üretilmesi sırasında otomatik olarak sadece bir kez çalışır.
        //Ctor methodu bir nesne örneği için sadece bir kez çalışır.
        //Bir nesnenin üretilebilmesi için Ctor çalışmak zorundadır. Özel olarak ctor'un yazılmadığı tiplerde c# arka planda içi boş
        //default bir ctor oluşturur. Böylece tip örneklenebilir hale gelir.
        public Book()
        {
            Console.WriteLine("Ctor çalıştı...");
        }
    }
}

