using System.Text;
using System.Threading.Tasks;

namespace _10_Event
{
    public delegate void speedDelegate(int speedValue);
    public class car
    {
        //herhangi bir object içerisinde de event fırlatılabilir.
        public event Action<int> speedEvent;

        private int _speed;


        public string Model { get; set; }

        public int Speed
        {
            get => _speed;

            set
            {

                if (value > 80 && speedEvent != null)
                {
                    speedEvent(value); //Event'ın fırlatıldığı an
                }
                else
                {
                    _speed = value;
                }

            }
        }






    }
    class Program
    {
        //Görsel programlada form uygulamasında butona tıkladığında event yazılmış oluyor . Textbox içine karakter kodlanması da aynı şekilde 
        //farkında olunmadan event kodu yazmış oluyoruz.Kullanıcının etkileşimi geçtiği yapılardır. 
        //Event'ler delegate ile kardeştir. Event kullanmak için delegate ihtiyaç vardır. Event otomatik olarak fırlatılır. 

        static void Main(string[] args)
        {

            car c = new car();
            c.Model = "Renault";
            c.speedEvent += (speedValue) =>
            {
                Console.WriteLine("hız sınırı aşıldı" + speedValue);
            };//(speedValue) => { Console.WriteLine("araba hız limitini aştı"); };   //=>lambda : Delegate ve Event'larda kullanılır. MEtodu kendisi oluşturur .
              //C_speedEvent; //+= sonrasında 2 kere TAB'a basılarak aşağıdaki metod oluşturuldu . 

            for (int i = 50; i < 100; i += 5)
            {
                System.Threading.Thread.Sleep(300);      //Sleep metodu o andaki kodu durdurur.300 ms duracak.

                c.Speed = i;
                Console.WriteLine("araç hızlanıyor.Araç hızı:" + i);
            }

        }

        //private static void C_speedEvent(int speedValue)
        //{
        //    Console.WriteLine("Araba hızını aştı:::: anlık hız durumu" + speedValue);
        //}
    }
}
