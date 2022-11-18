using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Auto_Property
{
    // Auto property'ler sadece veri taşıma işlemleri için kullanılır , herhangi bir validasyon ya da encapsülation kullanmazlar bu yönleriyle field'larla blokları olduğu için gerek duyulduğunda genişletilip encpsülation ve validasyon uygulanabilir hale getirilebilirler.
    class Urun
    {
        // Auto property kullanım şekli 
        public int Id { get; set; }

        public string UrunAdi { get; set; }

        public double Fiyat { get; set; }

        public double Kdv { get; set; }

        public double SadeceGet { get;  }
    }
}
