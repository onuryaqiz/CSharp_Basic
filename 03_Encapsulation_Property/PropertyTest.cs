using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation_Property
{
    class PropertyTest
    {
        int sadeceGetEdilebilirAlan = 10; // sadece get işlemi yapılabildiği için default bir değer ataması yaptık.
        int sadeceSetEdilebilirAlan;
        int setBloguPrivateAlan;

        public int SadeceGetEdilebilirAlan
        {
            get { return sadeceGetEdilebilirAlan; }
        }

        public int SadeceSetEdilebilirAlan
        {
            set { sadeceSetEdilebilirAlan = value; }
        }

        public int SetBloguPrivateAlan
        {
            get { return setBloguPrivateAlan; }

            // Set bloğu private olduğundan dolayı , property üzerinden yapılan atama işlemleri yalnızca bu sınıf tarafından gerçekleştirilebilir.
            private set { setBloguPrivateAlan = value; }
        }

        // Kendi içerisinde bir hesaplama yapıp sonucunu dönen bir property tasarlayabiliriz. Ancak bu property'nin private bir field'ı olmadığından sadece get işlemi yapabilir.
        public double HesaplananAlan
        {
            get { return sadeceGetEdilebilirAlan + sadeceSetEdilebilirAlan / 2; }
        }

        // Aynı class içerisinde olduğu iin aşağıdaki method ile private olan set bloğuna set işlemi gerçekleştirebiliriz.
        void SetBloguPrivateAlanTest()
        {
            SetBloguPrivateAlan = 10;
        }
        // Sadece Get bloğu olan property'lere bu şekilde class'ın içerisindeki bir method ile değer ataması yapılabilir.
        void SadeceGetEdilebilirAlanTest()
        {
            // SadeceGetEdilebilirAlan=10;
            sadeceGetEdilebilirAlan = 20;
        }
    }
}
