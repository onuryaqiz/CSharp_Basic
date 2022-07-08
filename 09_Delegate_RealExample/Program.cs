namespace _09_Delegate_RealExample
{

    public delegate bool promosyonDelagate(Employee employee);
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Ucret { get; set; }

        public int Tecrube { get; set; }

        public string sehir { get; set; }

        public static void promosyon(List<Employee> employee, promosyonDelagate promosyonDelagate)
        {
            foreach (var item in employee)
            {
                if (promosyonDelagate(item))
                {
                    Console.WriteLine(item.Name + " " + item.Tecrube);
                }
            }
        }



        //public static void Maas_ile_promosyon(List<Employee> employee, int Ucret)
        //{
        //    foreach (var item in employee)
        //    {
        //        if (item.Ucret >= Ucret)
        //        {
        //            Console.WriteLine(item.Name + " " + item.Surname);
        //        }
        //    }
        //}

        //public static void tecrube_ile_promosyon(List<Employee> employee, int tecrube)
        //{
        //    foreach (var item in employee)
        //    {
        //        if (item.Tecrube >= tecrube)
        //        {
        //            Console.WriteLine(item.Name + " " + item.Surname);
        //        }
        //    }
        //}
    }
    class Program
    {

        public static void Main(string[] args)
        {
            //Program yazarken işçi sınıfının ismi ,maaşı ,tecrübesi var . Bu işçi sınıfı içerisinde bir method oluşturulmak isteniyor . Maaşı 3000'den
            //fazla olanlara promosyon verilecek. 2.ay da tecrübesi 2 yıldan fazla olanlara ek promosyon verilsin. 2 ayrı method yazılmadan , delegate ile bu durumdan ,
            //kurtulabiliriz.


            Employee e1 = new Employee { Name = "onur", Surname = "yağız", Ucret = 1000, Tecrube = 1, sehir = "istanbul" };
            Employee e2 = new Employee { Name = "mehmet", Surname = "yağız", Ucret = 2000, Tecrube = 2, sehir = "ankara" };
            Employee e3 = new Employee { Name = "hasan", Surname = "yağız", Ucret = 3000, Tecrube = 3, sehir = "aydın" };
            Employee e4 = new Employee { Name = "ali", Surname = "yağız", Ucret = 4000, Tecrube = 4, sehir = "denizli" };
            Employee e5 = new Employee { Name = "ömer", Surname = "yağız", Ucret = 5000, Tecrube = 5, sehir = "izmir" };

            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);

            //Employee.promosyon(employees, new promosyonDelagate(maas_promosyon3000));
            Employee.promosyon(employees, e => e.sehir == "istanbul"); //bool delagate olduğu için == kullanıldı.

            // Employee.Maas_ile_promosyon(employees, 2000);

            //Employee.tecrube_ile_promosyon(employees, 4);
        }

        //public static bool maas_promosyon3000(Employee e)
        //{
        //    if (e.Ucret >= 3000)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool tecrube_promosyon3(Employee e)

        //{
        //    if (e.Tecrube >= 3)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}