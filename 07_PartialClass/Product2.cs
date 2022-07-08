using _07_Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PartialClass
{
    partial class Product : ikinci
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int ikinciProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ikincimethod()
        {
            throw new NotImplementedException();
        }
    }
    partial interface Iornek
    {
        void ornek2();
    }
}
