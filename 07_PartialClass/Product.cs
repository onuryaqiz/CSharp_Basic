using _07_Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PartialClass
{
    partial class Product : birinci,Iornek
    {
        public int birinciProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void birincimethod()
        {
            throw new NotImplementedException();
        }

        public void method1()
        {

        }

        public string method2()
        {
            return "onur";
        }

        public void ornek1()
        {
            throw new NotImplementedException();
        }

        public void ornek2()
        {
            throw new NotImplementedException();
        }
    }

    partial interface Iornek
    {
        void ornek1();
    }
}
