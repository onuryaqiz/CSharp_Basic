using _02_Ctor_MandatoryParameter;

namespace _061_Ctor_MandatoryParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student class'ının ctor'u parametre aldığı için , parametreleri göndermeden nesne üretemeyiz! Aşağıdaki kod bloğu derleme esnasında hata alır!

            //Student student = new Student();

            Student student = new Student("Onur", "Yağız", "Ali");

            // Ctor'da zorunlu olmayan alanlar daha sonra set ediliyor.
            student.DogumYeri = "Ankara";
            student.Yas = 12;

            Console.ReadKey();
        }
    }
}
