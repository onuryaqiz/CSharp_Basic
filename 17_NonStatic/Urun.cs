using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_NonStatic
{
     class Urun
    {
        // Bir üyeye static keyword'ü uygulanmadıkça o üye nonstatic'tir ve bir nesneye aittir.
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Urun (int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Info()
        {
            return string.Format("Id:{0} Name:{1} Price{2}", Id, Name, Price);
        }

        public void ZamYap(double oran)
        {
            Price += Price * oran;
            // this.Price+=Price*oran; üsttekiyle aynı işi yapar , this keyword'ünü kullanmasak da olur.

            // this keyword'ü non-static bir üyenin hizmet ettiği nesne örneğini getirir.
            Urun yeniUrun = this;
            yeniUrun.Price = 10000;

            // Üretilen nesneyi başka bir iş parçasına(başka bir method'a ) gönderdik.
            Info(this); 
        }

        public string Info(Urun urun)
        {
            return string.Format("Id: {0} Ad: {1} Fiyat: {2}", urun.Id, urun.Name, urun.Price);
        }
    }
}
