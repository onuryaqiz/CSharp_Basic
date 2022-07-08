namespace _04_Virtual
{
    class Program
    {

        static void Main(string[] args)
        {
            //Abstract methodların gövdeleri yoktu. 
            //Virtual methodlar , alt sınıflarda istenirse override edilebilir. İstenirse edilmeyebilir. 
            //Virtual methodlarda , abstract methodun aksine method gövdeleri vardır. 
            //Bu method gövdeleri olduğundan dolayı main methodtaki gövde çalışır . Override edersek , override edilmiş şekilde çalışır. 

            subClass subClass = new subClass();
            Console.WriteLine(subClass.getName("onur", "yağız"));


        }
        public abstract class baseClass
        {

            public abstract string getProduct(int id);

            public virtual string getName(string name, string surname)

            {
                return name + " " + surname;
            }
        }
        public class subClass : baseClass
        {
            public override string getProduct(int id)
            {
                throw new NotImplementedException();
            }
            public override string getName(string name, string surname)
            {
                return name.ToUpper() + " " + surname.ToUpper();
            }
        }

    }



}